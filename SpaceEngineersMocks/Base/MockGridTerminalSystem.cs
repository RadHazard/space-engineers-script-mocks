using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.ModAPI.Ingame;

namespace SpaceEngineersMocks.Base
{
    /// <summary>
    /// The mock for the GridTerminalSystem
    /// </summary>
    public class MockGridTerminalSystem : IMyGridTerminalSystem
    {

        private List<IMyTerminalBlock> blocks;

        public MockGridTerminalSystem()
        {
            blocks = new List<IMyTerminalBlock>();
        }

        /// <summary>
        /// Registers a mock block with this terminal system
        /// </summary>
        /// <param name="block">The block to register</param>
        public void RegisterBlock(IMyTerminalBlock block)
        {
            blocks.Add(block);
        }

        //  Interface Implementation
        // -----------------------------------------

        public void GetBlockGroups(List<IMyBlockGroup> blockGroups)
        {
            throw new NotImplementedException();
        }

        public void GetBlocks(List<IMyTerminalBlock> blocks)
        {
            blocks.AddList(this.blocks);
        }

        public void GetBlocksOfType<T>(List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect = null)
        {
            foreach (var block in this.blocks)
            {
                if (block is T)
                {
                    if (collect == null || collect.Invoke(block)) blocks.Add(block);
                }
            }
        }

        public IMyTerminalBlock GetBlockWithName(string name)
        {
            throw new NotImplementedException();
        }

        public void SearchBlocksOfName(string name, List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect = null)
        {
            throw new NotImplementedException();
        }
    }
}
