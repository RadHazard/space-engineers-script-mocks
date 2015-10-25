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
using Sandbox.Common.ObjectBuilders;

namespace SpaceEngineersMocks.Blocks
{
    /// <summary>
    /// TODO
    /// </summary>
    public class MockTextPanel : MockFunctionalBlock, IMyTextPanel
    {

        //  Interface Implementation
        // -----------------------------------------
        public void AddImagesToSelection(List<string> ids, bool checkExistance = false)
        {
            throw new NotImplementedException();
        }

        public void AddImageToSelection(string id, bool checkExistance = false)
        {
            throw new NotImplementedException();
        }

        public void ClearImagesFromSelection()
        {
            throw new NotImplementedException();
        }

        public string GetPrivateText()
        {
            throw new NotImplementedException();
        }

        public string GetPrivateTitle()
        {
            throw new NotImplementedException();
        }

        public string GetPublicText()
        {
            throw new NotImplementedException();
        }

        public string GetPublicTitle()
        {
            throw new NotImplementedException();
        }

        public void RemoveImageFromSelection(string id, bool removeDuplicates = false)
        {
            throw new NotImplementedException();
        }

        public void RemoveImagesFromSelection(List<string> ids, bool removeDuplicates = false)
        {
            throw new NotImplementedException();
        }

        public void SetShowOnScreen(ShowTextOnScreenFlag set)
        {
            throw new NotImplementedException();
        }

        public void ShowPrivateTextOnScreen()
        {
            throw new NotImplementedException();
        }

        public void ShowPublicTextOnScreen()
        {
            throw new NotImplementedException();
        }

        public void ShowTextureOnScreen()
        {
            throw new NotImplementedException();
        }

        public bool WritePrivateText(string value, bool append = false)
        {
            throw new NotImplementedException();
        }

        public bool WritePrivateTitle(string value, bool append = false)
        {
            throw new NotImplementedException();
        }

        public bool WritePublicText(string value, bool append = false)
        {
            throw new NotImplementedException();
        }

        public bool WritePublicTitle(string value, bool append = false)
        {
            throw new NotImplementedException();
        }
    }
}