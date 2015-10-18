using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common.ObjectBuilders;
using Sandbox.ModAPI.Interfaces;
using VRage;
using VRage.Components;
using VRage.ModAPI;
using VRage.ObjectBuilders;
using VRage.Utils;
using VRageMath;

namespace SpaceEngineersMocks.Interfaces
{
    public class MockInventory : IMyInventory
    {

        private List<MockInventoryItem> items;

        public MockInventory()
        {
            items = new List<MockInventoryItem>();
            MaxVolume = MyFixedPoint.MaxValue;
        }

        /// <summary>
        /// Adds a mock inventory item to the mock inventory
        /// </summary>
        /// <param name="item"></param>
        public void AddMockItem(MockInventoryItem item)
        {
            items.Add(item);
        }

        //  Interface Implementation
        // -----------------------------------------

        public MyFixedPoint CurrentMass
        {
            get
            {
                double mass = 0.0f;
                foreach(var item in items)
                {
                    mass += item.Mass;
                }
                return (MyFixedPoint)mass;
            }
        }

        public MyFixedPoint CurrentVolume
        {
            get
            {
                double volume = 0.0f;
                foreach (var item in items)
                {
                    volume += (float)item.Amount;
                }
                return (MyFixedPoint)volume;
            }
        }

        public bool IsFull{ get { return CurrentVolume >= MaxVolume; } }

        public MyFixedPoint MaxVolume{ get; set; }

        public IMyInventoryOwner Owner
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Vector3 Size
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool CanItemsBeAdded(MyFixedPoint amount, SerializableDefinitionId contentId)
        {
            throw new NotImplementedException();
        }

        public bool ContainItems(MyFixedPoint amount, MyObjectBuilder_PhysicalObject ob)
        {
            throw new NotImplementedException();
        }

        public IMyInventoryItem FindItem(SerializableDefinitionId contentId)
        {
            throw new NotImplementedException();
        }

        public MyFixedPoint GetItemAmount(SerializableDefinitionId contentId, MyItemFlags flags = MyItemFlags.None)
        {
            throw new NotImplementedException();
        }

        public IMyInventoryItem GetItemByID(uint id)
        {
            throw new NotImplementedException();
        }

        public List<IMyInventoryItem> GetItems()
        {
            var list = new List<IMyInventoryItem>();
            foreach (var item in items) list.Add(item);
            return list;
        }

        public bool IsConnectedTo(IMyInventory dst)
        {
            throw new NotImplementedException();
        }

        public bool IsItemAt(int position)
        {
            return items.Count >= position;
        }

        public bool TransferItemFrom(IMyInventory sourceInventory, int sourceItemIndex, int? targetItemIndex = default(int?), bool? stackIfPossible = default(bool?), MyFixedPoint? amount = default(MyFixedPoint?))
        {
            throw new NotImplementedException();
        }

        public bool TransferItemTo(IMyInventory dst, int sourceItemIndex, int? targetItemIndex = default(int?), bool? stackIfPossible = default(bool?), MyFixedPoint? amount = default(MyFixedPoint?))
        {
            throw new NotImplementedException();
        }
    }
}
