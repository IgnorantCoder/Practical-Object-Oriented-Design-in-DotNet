using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    class WheelData
    {
        public double Rim { get; }
        public double Tire { get; }

        public WheelData(double rim, double tire)
        {
            this.Rim = rim;
            this.Tire = tire;
        }

        public double Diameter()
        {
            return this.Rim + this.Tire * 2.0;
        }

        public double Circumference()
        {
            return this.Diameter() * Math.PI;
        }
    }

    class Gear
    {
        private double Chainring { get; }
        private double Cog { get; }
        private Lazy<WheelData> Wheel { get; }

        public Gear(double chainring, double cog, double rim, double tire)
        {
            this.Chainring = chainring;
            this.Cog = cog;
            this.Wheel = new Lazy<WheelData>(() => new WheelData(rim, tire));
        }

        public double GearInches()
        {
            return this.Ratio() * this.Wheel.Value.Diameter();
        }

        public double Ratio()
        {
            return this.Chainring / this.Cog;
        }
    }
}
