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
    public class MockProjector : MockFunctionalBlock, IMyProjector
    {

        //  Interface Implementation
        // -----------------------------------------
        public int ProjectionOffsetX
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ProjectionOffsetY
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ProjectionOffsetZ
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ProjectionRotX
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ProjectionRotY
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ProjectionRotZ
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int RemainingBlocks
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void LoadBlueprint(string name)
        {
            throw new NotImplementedException();
        }

        public void LoadRandomBlueprint(string searchPattern)
        {
            throw new NotImplementedException();
        }
    }
}