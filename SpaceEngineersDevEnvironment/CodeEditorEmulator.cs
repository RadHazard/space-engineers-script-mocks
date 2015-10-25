using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sandbox.Common;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using SpaceEngineersMocks;
using SpaceEngineersMocks.Base;
using SpaceEngineersMocks.Blocks;
using SpaceEngineersMocks.Interfaces;

namespace SpaceEngineersScripts
{
    class CodeEditorEmulator
    {
        MockGridTerminalSystem GridTerminalSystem;

        public static int Main(string[] args)
        {
            CodeEditorEmulator emulator = new CodeEditorEmulator();
            emulator.PreScript();
            emulator.Main();
            emulator.PostScript();

            return 0;
        }

        public CodeEditorEmulator()
        {
            GridTerminalSystem = new MockGridTerminalSystem();
        }

        // -----------------------------------------
        //  Pre-/Post-script Section
        //  Do any setup and verification in these
        //  methods
        // -----------------------------------------

        public void PreScript()
        {
            
        }

        public void PostScript()
        {
            
        }

        // -----------------------------------------
        //  Code section
        //  Place your script between these tags
        // -----------------------------------------


        #region CodeEditor
        void Main()
        {

        }
        #endregion
    }
}
