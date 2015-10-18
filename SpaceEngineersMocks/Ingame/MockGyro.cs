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
    public class MockGyro : MockFunctionalBlock, IMyGyro
    {

        //  Interface Implementation
        // -----------------------------------------
        public bool GyroOverride
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float GyroPower
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Pitch
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Roll
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Yaw
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}