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
    public class MockTimerBlock : MockFunctionalBlock, IMyTimerBlock
    {

        //  Interface Implementation
        // -----------------------------------------
        public bool IsCountingDown
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float TriggerDelay
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}