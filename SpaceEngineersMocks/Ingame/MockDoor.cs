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
    public class MockDoor : MockFunctionalBlock, IMyDoor
    {

        //  Interface Implementation
        // -----------------------------------------
        public bool Open
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float OpenRatio
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
