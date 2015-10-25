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
    public class MockSoundBlock : MockFunctionalBlock, IMySoundBlock
    {

        //  Interface Implementation
        // -----------------------------------------
        public bool IsSoundSelected
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float LoopPeriod
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Range
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Volume
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}