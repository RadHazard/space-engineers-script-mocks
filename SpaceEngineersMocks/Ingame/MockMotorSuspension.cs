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
    public class MockMotorSuspension : MockFunctionalBlock, IMyMotorSuspension
    {

        //  Interface Implementation
        // -----------------------------------------
        public bool Brake
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float Damping
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Friction
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Height
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool InvertSteer
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float MaxSteerAngle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Power
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Propulsion
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float SteerAngle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Steering
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float SteerReturnSpeed
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float SteerSpeed
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Strength
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float SuspensionTravel
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}