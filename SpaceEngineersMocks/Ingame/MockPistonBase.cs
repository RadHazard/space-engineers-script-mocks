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
    public class MockPistonBase : MockFunctionalBlock, IMyPistonBase
    {

        //  Interface Implementation
        // -----------------------------------------
        public float CurrentPosition
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float MaxLimit
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float MinLimit
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PistonStatus Status
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