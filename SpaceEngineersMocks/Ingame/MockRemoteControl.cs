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
    public class MockRemoteControl : MockShipController, IMyRemoteControl
    {

        //  Interface Implementation
        // -----------------------------------------
        public void AddWaypoint(Vector3D point, string name)
        {
            throw new NotImplementedException();
        }

        public void ClearWaypoints()
        {
            throw new NotImplementedException();
        }

        public Vector3D GetFreeDestination(Vector3D originalDestination, float checkRadius, float shipRadius)
        {
            throw new NotImplementedException();
        }

        public Vector3D GetNaturalGravity()
        {
            throw new NotImplementedException();
        }

        public bool GetNearestPlayer(out Vector3D playerPosition)
        {
            throw new NotImplementedException();
        }

        public void SetAutoPilotEnabled(bool enabled)
        {
            throw new NotImplementedException();
        }
    }
}