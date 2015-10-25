using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common;
using Sandbox.ModAPI.Ingame;
using SpaceEngineersMocks.Interfaces;
using SpaceEngineersMocks.Supertypes;

namespace SpaceEngineersMocks.Blocks
{
    public class MockRefinery : MockProductionBlock, IMyRefinery
    {
        /// <summary>
        /// Creates a new Mock Refinery
        /// </summary>
        public MockRefinery() : base(2) { }

        //  Interface Implementation
        // -----------------------------------------
    }
}