using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using VRage.Components;
using VRage.ModAPI;
using VRage.ObjectBuilders;
using VRage.Utils;
using VRageMath;
using SpaceEngineersMocks.Interfaces;

namespace SpaceEngineersMocks.Supertypes
{
    /// <summary>
    /// Dirty hack to get around lack of multiple inheritence.
    /// Base class for all InventoryOwners that are also FunctionalBlocks
    /// </summary>
    public abstract class MockFunctionalInventoryOwner : MockInventoryOwner, IMyFunctionalBlock
    {
        public MockFunctionalInventoryOwner(int inventoryCount) : base(inventoryCount) { }

        //  Interface Implementation
        // -----------------------------------------

        public bool Enabled { get; private set; }

        public void RequestEnable(bool enable)
        {
            Enabled = enable;
        }
    }
}
