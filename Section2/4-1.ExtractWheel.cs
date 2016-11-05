using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class Gear {
        private WheelData Wheel { get; }
        private int Chainring { get; }
        private int Cog { get; }

        public Gear(int chainring, int cog)
            : this(chainring, cog, null)
        {
        }

        public Gear(int chainring, int cog, WheelData wheel)
        {
            this.Chainring = chainring;
            this.Cog = cog;
            this.Wheel = wheel;
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

    class WheelData {
        public int Rim { get; }
        public int Tire { get; }

        public WheelData(int rim, int tire)
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

    class Program {
        /// <summary>
        ///   The main entry point for the application
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            var wheel = new WheelData(26, 1.5);
            System.IO.Console.WriteLine(wheel.Circumference()); //91.106186954104
            System.IO.Console.WriteLine(new Gear(51, 11, wheel).GearInches()); //137.090909090909
            System.IO.Console.WriteLine(new Gear(51, 11).Ratio()); //4.72727272727273
        }
    }
}
