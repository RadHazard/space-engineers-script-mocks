using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common;
using Sandbox.ModAPI.Ingame;

namespace SpaceEngineersMocks
{
    public class MockRefinery : MockInventoryOwner, IMyRefinery
    {
        /// <summary>
        /// Creates a new Mock Refinery
        /// </summary>
        public MockRefinery() : base(2) { }

        // Interface Implementation

        public bool Enabled { get; set; }

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

        public void RequestEnable(bool enable)
        {
            throw new NotImplementedException();
        }
    }
}