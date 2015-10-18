using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.ModAPI.Ingame;

namespace SpaceEngineersMocks
{
    public class MockGridTerminalSystem : IMyGridTerminalSystem
    {

        private List<IMyTerminalBlock> _blocks;

        public MockGridTerminalSystem()
        {
            _blocks = new List<IMyTerminalBlock>();
        }

        public void RegisterBlock(IMyTerminalBlock block)
        {
            _blocks.Add(block);
        }

        // Interface Implementation

        public void GetBlockGroups(List<IMyBlockGroup> blockGroups)
        {
            throw new NotImplementedException();
        }

        public void GetBlocks(List<IMyTerminalBlock> blocks)
        {
            blocks.AddList(_blocks);
        }

        public void GetBlocksOfType<T>(List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect = null)
        {
            foreach (var block in _blocks)
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
