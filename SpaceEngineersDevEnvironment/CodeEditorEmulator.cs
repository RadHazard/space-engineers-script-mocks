using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sandbox.Common;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using SpaceEngineersMocks;

namespace SpaceEngineersScripts
{
    class CodeEditorEmulator
    {
        MockGridTerminalSystem GridTerminalSystem;

        public static int Main(string[] args)
        {
            CodeEditorEmulator emulator = new CodeEditorEmulator();
            emulator.PreScript();
            emulator.Main();
            emulator.PostScript();

            return 0;
        }

        public CodeEditorEmulator()
        {
            GridTerminalSystem = new MockGridTerminalSystem();
        }

        // -----------------------------------------
        //  Pre-/Post-script Section
        //  Do any setup and verification in these
        //  methods
        // -----------------------------------------

        public void PreScript()
        {
            for (int i = 0; i < 5; i++)
            {
                MockRefinery refinery = new MockRefinery();
                GridTerminalSystem.RegisterBlock(refinery);
            }

            for (int i = 0; i < 5; i++)
            {
                MockRefinery refinery = new MockRefinery();
                var inventory = refinery.GetMockInventory(0);
                inventory.AddMockItem(new MockInventoryItem(1000));
                inventory.AddMockItem(new MockInventoryItem(1000));
                GridTerminalSystem.RegisterBlock(refinery);
            }
        }

        public void PostScript()
        {
            
        }

        // -----------------------------------------
        //  Code section
        //  Place your script between these tags
        // -----------------------------------------


        #region CodeEditor
        // Refinery Manager - CUSTOM HACK
        //-------------------------------------------------------------
        // Refinery Manager distributes the ores between refineries
        // This version is objectively better in every way :P


        // Setup
        //-------------------------------------------------------------
        // 1. Place a Programmable Block
        // 2. Load Refinery Manager into the Programmable Block
        // 3. Place a Timer Block and setup two actions:
        //     a) Programming Block - Run
        //     b) Timer Block - Start
        // 4. Set the delay of the Timer Block to a suitable value (i prefere 3 Sek. - the script runs in no time)
        // 5. Press Start and watch your refineries getting REAL hot!


        // Config
        //-------------------------------------------------------------
        // The managedGroups defines a list of the names of one or more refinery groups to be managed
        // If it is set to null or the empty list, it will be ignored.
        // Otherwise, each group is separately managed, with all refineries in each group being autobalanced with each other
        // 
        // This parameter is case sensitive and each entry must exactly match the name of the group.
        //
        // Example:
        // string[] managedGroups = {"groupA", "groupB"};
        //
        // DEFINE YOUR GROUP CAREFULLY! I tried to prevent problems if you add non refineries
        // to your group, but with the current coding restrictions i am not able to do this.
        // If you add non refineries to your group the script WILL cause errors.
        // This might change in future.

        string[] managedGroups = { };



        //------------------------------------------------------------------------------------------------------------------------------------------------------
        // code
        //------------------------------------------------------------------------------------------------------------------------------------------------------

        void Main()
        {
            if (managedGroups == null || managedGroups.Length == 0)
            {
                Autobalance(getRefineries());
            }
            else
            {
                for (int i = 0; i < managedGroups.Length; i++)
                {
                    Autobalance(getGroupedRefineries(managedGroups[i]));
                }
            }
        }

        // The main autobalancing script
        void Autobalance(List<IMyTerminalBlock> refineries)
        {
            PriorityQueue WorkingRefineryQueue = new PriorityQueue(refineries.Count);
            List<MRefinery> EmptyRefineries = new List<MRefinery>();



            for (int i = 0; i < refineries.Count; i++)
            {
                if (refineries[i].IsWorking &&
                    ((IMyProductionBlock)refineries[i]).UseConveyorSystem)
                {
                    var refinery = new MRefinery((IMyRefinery)refineries[i]);

                    if (refinery.HasWork)
                    {
                        WorkingRefineryQueue.Enqueue(refinery);
                    }
                    else
                    {
                        EmptyRefineries.Add(refinery);
                    }
                }
            }

            for (int i = 0; i < EmptyRefineries.Count; i++)
            {
                if (!WorkingRefineryQueue.HasNext()) return; // Can't rebalance if there are no working refineries
                var Src = WorkingRefineryQueue.Dequeue();
                Src.RebalanceWith(EmptyRefineries[i]);
                WorkingRefineryQueue.Enqueue(Src);
            }
        }

        // Refinery structure
        public struct MRefinery
        {

            public IMyTerminalBlock Refinery;
            public IMyInventory Inventory;
            public bool HasWork;
            public long Amount;

            public MRefinery(IMyRefinery Refinery)
            {
                this.Refinery = Refinery;
                Inventory = Refinery.GetInventory(0);
                HasWork = false;
                Amount = 0;

                RecalculateInventory();

                HasWork = (Amount > 0);

            }

            // Recalculates the total amount of items this refinery has
            public void RecalculateInventory()
            {
                Amount = 0;

                var Items = Inventory.GetItems();
                for (int i = 0; i < Items.Count; i++)
                {
                    Amount += Items[i].Amount.RawValue;
                }
            }

            // Compares the amount of items this refinery has to another refinery
            public int CompareTo(MRefinery other)
            {
                return (int)(other.Amount - Amount);
            }

            // Transfers half of this refinery's inventory to another refinery
            public void RebalanceWith(MRefinery Other)
            {
                float AmountToMove = Amount / 2;

                while (AmountToMove > 0)
                {
                    var Items = Inventory.GetItems();
                    var CurrAmount = Items[0].Amount;

                    if (CurrAmount.RawValue < AmountToMove)
                    {
                        // If the current stack is less than the total amount to move, move
                        // the whole stack
                        Inventory.TransferItemTo(Other.Inventory, 0, null, null, CurrAmount);

                        AmountToMove -= CurrAmount.RawValue;
                    }
                    else
                    {
                        // Otherwise, only move what we need to move
                        var TransferAmount = (VRage.MyFixedPoint)(AmountToMove);
                        Inventory.TransferItemTo(Other.Inventory, 0, null, null, CurrAmount);

                        AmountToMove = 0.0f;
                    }
                }

                RecalculateInventory();
            }
        }

        // Priority Queue implementation using an underlying heap array
        public struct PriorityQueue
        {
            MRefinery[] Array;
            int Index;

            public PriorityQueue(int Capacity)
            {
                Array = new MRefinery[Capacity];
                Index = -1;
            }

            public bool HasNext()
            {
                return Index >= 0;
            }

            public void Enqueue(MRefinery item)
            {
                Array[++Index] = item;
                MoveUp(Index);
            }

            public MRefinery Dequeue()
            {
                MRefinery item = Array[0];
                Array[0] = Array[Index--];
                MoveDown(0);
                return item;
            }

            // Sifts an element upward in the heap
            private void MoveUp(int i)
            {
                if (i == 0) return;

                int Parent = GetParent(i);
                if (Array[i].CompareTo(Array[Parent]) > 0) Swap(i, Parent);
                MoveUp(Parent);
            }

            // Sifts an element downward in the heap
            private void MoveDown(int i)
            {
                int LeftChild = GetLeftChild(i);
                int RightChild = GetRightChild(i);

                int FavoriteChild = (Array[LeftChild].CompareTo(Array[RightChild]) > 0) ? LeftChild : RightChild;
                if (Array[i].CompareTo(Array[FavoriteChild]) > 0) Swap(i, FavoriteChild);
                MoveDown(FavoriteChild);
            }

            private int GetParent(int i)
            {
                return (i - 1) / 2;
            }

            private int GetLeftChild(int i)
            {
                return (2 * i) + 1;
            }

            private int GetRightChild(int i)
            {
                return (2 * i) + 2;
            }

            // Swaps two elements
            private void Swap(int i, int j)
            {
                MRefinery temp = Array[j];
                Array[j] = Array[i];
                Array[i] = temp;
            }
        }

        // getGroupedRefineries
        // returns a list of refineries grouped by a group name
        List<IMyTerminalBlock> getGroupedRefineries(String groupName)
        {
            List<IMyTerminalBlock> retval = new List<IMyTerminalBlock>();
            IMyBlockGroup group = getGroupByName(groupName);
            if (group != null)
            {
                retval = group.Blocks; // get blocks from group
                                       // the current namespace restrictions prevent me
                                       // to do something usefull here like filtering
                                       // refineries
            }
            return retval;
        }


        // getGroupByName
        // returns a IMyBlockGroup with the given name
        IMyBlockGroup getGroupByName(String groupName)
        {
            List<IMyBlockGroup> blockGroups = new List<IMyBlockGroup>();
            GridTerminalSystem.GetBlockGroups(blockGroups);
            for (int i = 0; i < blockGroups.Count; i++)
            {
                if (blockGroups[i].Name.IndexOf(groupName) == 0)
                {
                    return blockGroups[i];
                }
            }
            return null;
        }


        // getRefineries()
        // returns a list of all refineries
        // -----------------------------------------------------
        List<IMyTerminalBlock> getRefineries()
        {
            var refineries = new List<IMyTerminalBlock>();
            GridTerminalSystem.GetBlocksOfType<IMyRefinery>(refineries);
            return refineries;
        }

        // Returns a list of all antennas
        // -----------------------------------------------------
        List<IMyTerminalBlock> getAntennas()
        {
            var antennas = new List<IMyTerminalBlock>();
            GridTerminalSystem.GetBlocksOfType<IMyRadioAntenna>(antennas);
            return antennas;
        }

        // -----------------------------------------------------
        void Debug(string Message)
        {
            List<IMyTerminalBlock> antennas = getAntennas();
            if (antennas.Count > 0)
            {
                antennas[0].SetCustomName(Message);
            }
        }
        #endregion
    }
}
