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
    public class MockMotorStator : MockFunctionalBlock, IMyMotorStator
    {

        //  Interface Implementation
        // -----------------------------------------
        public float Angle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float BrakingTorque
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Displacement
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsAttached
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float LowerLimit
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Torque
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float UpperLimit
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Velocity
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}