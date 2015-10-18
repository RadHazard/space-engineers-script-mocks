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
using SpaceEngineersMocks.Base;

namespace SpaceEngineersMocks.Supertypes
{
    /// <summary>
    /// Base class for all blocks
    /// TODO
    /// </summary>
    public abstract class MockTerminalBlock : MockCubeBlock, IMyTerminalBlock
    {
        //  Overrides
        // -----------------------------------------

        new public bool IsFunctional { get; set; }

        new public bool IsWorking { get; set; }

        new public bool IsBeingHacked { get; set; }


        //  Interface Implementation
        // -----------------------------------------

        public string CustomInfo
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string CustomName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string CustomNameWithFaction
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string DetailedInfo
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool ShowOnHUD
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void GetActions(List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect = null)
        {
            throw new NotImplementedException();
        }

        public ITerminalAction GetActionWithName(string name)
        {
            throw new NotImplementedException();
        }

        public void GetProperties(List<ITerminalProperty> resultList, Func<ITerminalProperty, bool> collect = null)
        {
            throw new NotImplementedException();
        }

        public ITerminalProperty GetProperty(string id)
        {
            throw new NotImplementedException();
        }

        public bool HasLocalPlayerAccess()
        {
            throw new NotImplementedException();
        }

        public bool HasPlayerAccess(long playerId)
        {
            throw new NotImplementedException();
        }

        public void RequestShowOnHUD(bool enable)
        {
            throw new NotImplementedException();
        }

        public void SearchActionsOfName(string name, List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect = null)
        {
            throw new NotImplementedException();
        }

        public void SetCustomName(StringBuilder text)
        {
            throw new NotImplementedException();
        }

        public void SetCustomName(string text)
        {
            throw new NotImplementedException();
        }
    }
}
