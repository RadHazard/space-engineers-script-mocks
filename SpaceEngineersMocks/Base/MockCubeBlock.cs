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

namespace SpaceEngineersMocks.Base
{
    /// <summary>
    /// Mock for IMyCubeBlock
    /// Most methods in this block are forbidden in scripting and so do not need implementations
    /// Any that do need implementations should be overridden in MockTerminalBlock instead
    /// </summary>
    public class MockCubeBlock : MockEntity, IMyCubeBlock
    {

        //  Interface Implementation
        // -----------------------------------------
        public SerializableDefinitionId BlockDefinition
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool CheckConnectionAllowed
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IMyCubeGrid CubeGrid
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string DefinitionDisplayNameText
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float DisassembleRatio
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string DisplayNameText
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsBeingHacked
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsFunctional
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsWorking
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Mass
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Vector3I Max
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Vector3I Min
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int NumberInGrid
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MyBlockOrientation Orientation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public long OwnerId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Vector3I Position
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string GetOwnerFactionTag()
        {
            throw new NotImplementedException();
        }

        public MyRelationsBetweenPlayerAndBlock GetPlayerRelationToOwner()
        {
            throw new NotImplementedException();
        }

        public MyRelationsBetweenPlayerAndBlock GetUserRelationToOwner(long playerId)
        {
            throw new NotImplementedException();
        }

        public void UpdateIsWorking()
        {
            throw new NotImplementedException();
        }

        public void UpdateVisual()
        {
            throw new NotImplementedException();
        }
    }
}
