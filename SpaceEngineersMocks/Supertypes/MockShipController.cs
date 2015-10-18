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
    /// Base class for any block that can control ships
    /// TODO
    /// </summary>
    public abstract class MockShipController : MockTerminalBlock, IMyShipController
    {

        //  Interface Implementation
        // -----------------------------------------
        public bool ControlThrusters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool ControlWheels
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool DampenersOverride
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool HandBrake
        {
            get
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
    }
}