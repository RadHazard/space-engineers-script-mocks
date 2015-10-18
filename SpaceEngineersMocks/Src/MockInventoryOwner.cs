using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.ModAPI.Interfaces;
using VRage.Components;
using VRage.ModAPI;
using VRage.ObjectBuilders;
using VRage.Utils;
using VRageMath;

namespace SpaceEngineersMocks
{
    public class MockInventoryOwner : MockTerminalBlock, IMyInventoryOwner
    {

        private MockInventory[] inventories;
        
        /// <summary>
        /// Creates a new Mock Inventory Owner
        /// </summary>
        /// <param name="inventoryCount">The number of inventories this inventory owner has</param>
        public MockInventoryOwner(int inventoryCount)
        {
            inventories = new MockInventory[inventoryCount];
            for (int i = 0; i < inventories.Length; i++)
            {
                inventories[i] = new MockInventory();
            }
        }

        /// <summary>
        /// The same as GetInventory, but returns the MockInventory type to allow for easy mocking
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public MockInventory GetMockInventory(int index)
        {
            if (index >= 0 && index < InventoryCount)
            {
                return inventories[index];
            }
            else
            {
                return null;
            }
        }

        // Interface Implementation
        
        public int InventoryCount
        {
            get { return inventories.Length; }
        }

        public bool UseConveyorSystem{ get; set; }

        public IMyInventory GetInventory(int index)
        {
            if (index >= 0 && index < InventoryCount)
            {
                return inventories[index];
            }
            else
            {
                return null;
            }
        }
    }
}
