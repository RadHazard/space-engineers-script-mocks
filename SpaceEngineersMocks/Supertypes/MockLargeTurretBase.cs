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
    /// Base class for large turrets
    /// TODO
    /// </summary>
    public abstract class MockLargeTurretBase : MockUserControllableGun, IMyLargeTurretBase
    {

        //  Interface Implementation
        // -----------------------------------------
        public bool AIEnabled
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Azimuth
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

        public bool CanControl
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Elevation
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

        public bool EnableIdleRotation
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

        public bool IsUnderControl
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Range
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void ResetTargetingToDefault()
        {
            throw new NotImplementedException();
        }

        public void SetTarget(Vector3D pos)
        {
            throw new NotImplementedException();
        }

        public void SetTarget(IMyEntity Entity)
        {
            throw new NotImplementedException();
        }

        public void SyncAzimuth()
        {
            throw new NotImplementedException();
        }

        public void SyncElevation()
        {
            throw new NotImplementedException();
        }

        public void SyncEnableIdleRotation()
        {
            throw new NotImplementedException();
        }

        public void TrackTarget(IMyEntity entity)
        {
            throw new NotImplementedException();
        }

        public void TrackTarget(Vector3D pos, Vector3 velocity)
        {
            throw new NotImplementedException();
        }
    }
}