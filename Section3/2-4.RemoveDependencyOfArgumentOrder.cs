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
        private WheelData Wheel { get; }

        public Gear(double chainring, double cog, WheelData wheel)
        {
            this.Chainring = chainring;
            this.Cog = cog;
            this.Wheel = wheel;
        }

        public double GearInches()
        {
            return this.Ratio() * this.Wheel.Diameter();
        }

        public double Ratio()
        {
            return this.Chainring / this.Cog;
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
            var wheeldata = new WheelData(rim: 26, tire: 1.5);
            var gear = new Gear(chainring: 52, cog: 11, wheel: wheeldata);
            System.Console.WriteLine(gear.GearInches());
        }
    }
}
