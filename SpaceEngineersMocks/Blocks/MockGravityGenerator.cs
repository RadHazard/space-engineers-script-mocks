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
    public class MockGravityGenerator : MockGravityGeneratorBase, IMyGravityGenerator
    {

        //  Interface Implementation
        // -----------------------------------------
        public float FieldDepth
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float FieldHeight
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float FieldWidth
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Gravity
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}