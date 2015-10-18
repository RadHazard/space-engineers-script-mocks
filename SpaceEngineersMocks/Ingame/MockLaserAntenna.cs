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
    public class MockLaserAntenna : MockFunctionalBlock, IMyLaserAntenna
    {

        //  Interface Implementation
        // -----------------------------------------
        public bool IsOutsideLimits
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsPermanent
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Vector3D TargetCoords
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void SetTargetCoords(string coords)
        {
            throw new NotImplementedException();
        }
    }
}