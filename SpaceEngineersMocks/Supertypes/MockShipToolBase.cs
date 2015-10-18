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
    /// Base class for ship tools
    /// TODO
    /// </summary>
    public abstract class MockShipToolBase : MockFunctionalBlock, IMyShipToolBase
    {

        //  Interface Implementation
        // -----------------------------------------
        public bool UseConveyorSystem
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}