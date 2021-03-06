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
        private WheelData Wheel { get; }
        private double Chainring { get; }
        private double Cog { get; }

        public Gear(double chainring, double cog)
            : this(chainring, cog, null)
        {
        }

        public Gear(double chainring, double cog, WheelData wheel)
        {
            this.Chainring = chainring;
            this.Cog = cog;
            this.Wheel = wheel;
        }

        public double Ratio()
        {
            return this.Chainring / this.Cog;
        }

        public double GearInches()
        {
            return this.Ratio() * this.Wheel.Diameter();
        }
    }

    class Program
    {
        /// <summary>
        ///   The main entry point for the application
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            var wheel = new WheelData(26, 1.5);
            System.Console.WriteLine(wheel.Circumference()); //91.106186954104
            System.Console.WriteLine(new Gear(51, 11, wheel).GearInches()); //137.090909090909
            System.Console.WriteLine(new Gear(51, 11).Ratio()); //4.72727272727273
        }
    }
}
