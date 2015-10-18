using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common.ObjectBuilders;
using Sandbox.ModAPI.Interfaces;
using VRage;
using VRage.Components;
using VRage.ModAPI;
using VRage.ObjectBuilders;
using VRage.Utils;
using VRageMath;

namespace SpaceEngineersMocks
{
    public class MockInventoryItem : IMyInventoryItem
    {
        private float amount;
        private float density;

        public MockInventoryItem(float amount) : this(amount, 1.0f) { }

        public MockInventoryItem(float amount, float density)
        {
            this.amount = amount;
            this.density = density;
        }

        public float Mass { get { return amount * density; } }

        // Interface Implementation

        public MyFixedPoint Amount
        {
            get
            {
                return (MyFixedPoint)(double)amount;
            }

            set
            {
                amount = value.RawValue;
            }
        }

        public MyObjectBuilder_Base Content
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public uint ItemId
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
