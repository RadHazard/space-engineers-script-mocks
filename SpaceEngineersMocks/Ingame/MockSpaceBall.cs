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

namespace SpaceEngineersMocks.Ingame
{
    /// <summary>
    /// TODO
    /// </summary>
    public class MockSpaceBall : MockVirtualMass, IMySpaceBall
    {

        //  Interface Implementation
        // -----------------------------------------
        public float Friction
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsBroadcasting
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Restitution
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}