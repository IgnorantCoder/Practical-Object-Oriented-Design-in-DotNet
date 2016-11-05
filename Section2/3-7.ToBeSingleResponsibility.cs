using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class RevealingReferences {
        private class Wheel {
            public int Rim { get; }
            public int Tire { get; }
            public Wheel(int rim, int tire)
            {
                this.Rim = rim;
                this.Tire = tire;
            }
        }

        private static List<Wheel> Wheelify(List<int[]> data)
        {
            return data
                .Select(cell => new Wheel(cell[0], cell[1]))
                .ToList();
        }

        private List<Wheel> Wheels { get; }

        public RevealingReferences(List<int[]> data)
        {
            this.Wheels = Wheelify(data);
        }

        public double Diameters() {
            return this.Wheels.Aggregate(
                0.0,
                //(sum, wheel) => sum + (wheel.Rim + wheel.Tire * 2.0)
                (sum, wheel) => sum + Diameter(wheel));
        }

        public static double Diameter(Wheel wheel) {
            return wheel.Rim + wheel.Tire * 2.0;
        }
    }

    class Gear {
        private int Chainring { get; }
        private int Cog { get; }
        private int Rim { get; }
        private int Tire { get; }

        public Gear(int chainring, int cog, int rim, int tire)
        {
            this.Chainring = chainring;
            this.Cog = cog;
            this.Rim = rim;
            this.Tire = tire;
        }

        public double Ratio()
        {
            return this.Chainring / (double)this.Cog;
        }

        public double GearInches()
        {
            //return this.Ratio() * (this.Rim + (this.Tire * 2.0));
            return this.Ratio() * this.Diameter());
        }

        private double Diameter()
        {
            return this.Rim + (this.Tire * 2.0);
        }
    }
}
