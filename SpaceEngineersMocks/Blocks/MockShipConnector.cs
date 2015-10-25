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

namespace SpaceEngineersMocks.Blocks
{
    /// <summary>
    /// TODO
    /// </summary>
    public class MockShipConnector : MockFunctionalBlock, IMyShipConnector
    {

        //  Interface Implementation
        // -----------------------------------------
        public bool CollectAll
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsConnected
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsLocked
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IMyShipConnector OtherConnector
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool ThrowOut
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}