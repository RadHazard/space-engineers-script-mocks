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
    /// Base class for any block that can produce things
    /// TODO
    /// </summary>
    public abstract class MockProductionBlock : MockFunctionalInventoryOwner, IMyProductionBlock
    {

        public MockProductionBlock(int inventoryCount) : base(inventoryCount) { }

        //  Interface Implementation
        // -----------------------------------------

        public bool IsProducing
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsQueueEmpty
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public uint NextItemId
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        
        public void MoveQueueItemRequest(uint queueItemId, int targetIdx)
        {
            throw new NotImplementedException();
        }

        public void RemoveQueueItemRequest(int itemIdx)
        {
            throw new NotImplementedException();
        }
    }
}
