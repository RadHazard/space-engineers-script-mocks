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
using SpaceEngineersMocks.Supertypes;

namespace SpaceEngineersMocks.Blocks
{
    /// <summary>
    /// TODO
    /// </summary>
    public class MockBatteryBlock : MockFunctionalBlock, IMyBatteryBlock
    {

        //  Interface Implementation
        // -----------------------------------------
        public float CurrentStoredPower
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool HasCapacityRemaining
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float MaxStoredPower
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
