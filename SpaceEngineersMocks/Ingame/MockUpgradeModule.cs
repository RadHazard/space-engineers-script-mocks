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
using Sandbox.Common.ObjectBuilders.Definitions;

namespace SpaceEngineersMocks.Ingame
{
    /// <summary>
    /// TODO
    /// </summary>
    public class MockUpgradeModule : MockTerminalBlock, IMyUpgradeModule
    {

        //  Interface Implementation
        // -----------------------------------------
        public uint Connections
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public uint UpgradeCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void GetUpgradeList(out List<MyUpgradeModuleInfo> upgrades)
        {
            throw new NotImplementedException();
        }
    }
}