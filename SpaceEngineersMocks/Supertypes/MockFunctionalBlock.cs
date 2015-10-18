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
    /// Base class for any block that can be enabled or disabled
    /// </summary>
    public abstract class MockFunctionalBlock : MockTerminalBlock, IMyFunctionalBlock
    {

        //  Interface Implementation
        // -----------------------------------------

        public bool Enabled { get; private set; }

        public void RequestEnable(bool enable)
        {
            Enabled = enable;
        }
    }
}
