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
    /// TODO
    /// </summary>
    public class MockSlimBlock : IMySlimBlock
    {

        //  Interface Implementation
        // -----------------------------------------
        public float AccumulatedDamage
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float BuildIntegrity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float BuildLevelRatio
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

        public float CurrentDamage
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float DamageRatio
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IMyCubeBlock FatBlock
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool HasDeformation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsDestroyed
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsFullIntegrity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsFullyDismounted
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

        public float MaxDeformation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float MaxIntegrity
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

        public bool ShowParts
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool StockpileAllocated
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool StockpileEmpty
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void GetMissingComponents(Dictionary<string, int> addToDictionary)
        {
            throw new NotImplementedException();
        }

        public void UpdateVisual()
        {
            throw new NotImplementedException();
        }
    }
}