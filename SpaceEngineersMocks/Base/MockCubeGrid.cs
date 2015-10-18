using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common;
using Sandbox.Common.ObjectBuilders;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using VRage.Components;
using VRage.ModAPI;
using VRage.ObjectBuilders;
using VRage.Utils;
using VRageMath;

namespace SpaceEngineersMocks.Base
{
    /// <summary>
    /// TODO
    /// </summary>
    public class MockCubeGrid : MockEntity, IMyCubeGrid
    {

        //  Interface Implementation
        // -----------------------------------------
        public float GridSize
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MyCubeSize GridSizeEnum
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsStatic
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Vector3I Max
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Vector3I Min
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool CubeExists(Vector3I pos)
        {
            throw new NotImplementedException();
        }

        public IMySlimBlock GetCubeBlock(Vector3I pos)
        {
            throw new NotImplementedException();
        }

        public Vector3D GridIntegerToWorld(Vector3I gridCoords)
        {
            throw new NotImplementedException();
        }

        public Vector3I WorldToGridInteger(Vector3D coords)
        {
            throw new NotImplementedException();
        }
    }
}
