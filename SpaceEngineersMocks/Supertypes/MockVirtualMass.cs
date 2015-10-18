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
    /// Base class for virtual mass blocks, e.g. Mass Blocks, Space Balls
    /// TODO
    /// </summary>
    public abstract class MockVirtualMass : MockFunctionalBlock, IMyVirtualMass
    {

        //  Interface Implementation
        // -----------------------------------------
        public float VirtualMass
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}