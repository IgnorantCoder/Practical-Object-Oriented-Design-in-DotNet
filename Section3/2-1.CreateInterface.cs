using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    interface IHasDiameter
    {
        double Diameter();
    }

    class WheelData : IHasDiameter
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
        private IHasDiameter Wheel { get; }

        public Gear(double chainring, double cog, IHasDiameter wheel)
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
            System.Console.WriteLine(
                new Gear(51, 11, new WheelData(26, 1.5)).GearInches());
        }
    }
}
