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

        public Gear(WheelData wheel, double chainring = 40, double cog = 10)
        {
            this.Wheel = wheel;
            this.Chainring = chainring;
            this.Cog = cog;
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
            var wheeldata = new WheelData(26, 1.5);
            var gear = new Gear(wheeldata);
            System.Console.WriteLine(gear.GearInches());
        }
    }
}
