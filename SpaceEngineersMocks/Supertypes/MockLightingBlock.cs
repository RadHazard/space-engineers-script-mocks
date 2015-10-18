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

namespace SpaceEngineersMocks.Supertypes
{
    /// <summary>
    /// Base class for lighting blocks
    /// TODO
    /// </summary>
    public abstract class MockLightingBlock : MockFunctionalBlock, IMyLightingBlock
    {

        //  Interface Implementation
        // -----------------------------------------
        public float BlinkIntervalSeconds
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float BlinkLenght
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float BlinkOffset
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Intensity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Radius
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}