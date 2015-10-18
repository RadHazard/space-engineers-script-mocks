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
    /// Base class for large turrets that use conveyors
    /// TODO
    /// </summary>
    public abstract class MockLargeConveyorTurretBase : MockLargeTurretBase, IMyLargeConveyorTurretBase
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