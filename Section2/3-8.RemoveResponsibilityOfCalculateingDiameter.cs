using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class Gear {
        private class WheelData {
            public int Rim { get; }
            public int Tire { get; }

            public WheelData(int rim, int tire)
            {
                this.Rim = rim;
                this.Tire = tire;
            }

            public double Diameter() {
                return this.Rim + this.Tire * 2.0;
            }
        }

        private WheelData Wheel { get; }
        private int Chainring { get;
        private int Cog { get; }

        public Gear(int cahinring, int cog, int rim, int tire)
        {
            this.Chainring = chainring;
            this.Cog = cog;
            this.Wheel = new WheelData(rim, tire);
        }

        public double Ratio()
        {
            return this.Chainring / (double)this.Cog;
        }

        public double GearInches()
        {
            return this.Ratio() * this.Wheel.Diameter());
        }
    }
}
