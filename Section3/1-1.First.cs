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
        private double Rim { get; }
        private double Tire { get; }

        public Gear(double chainring, double cog, double rim, double tire)
        {
            this.Chainring = chainring;
            this.Cog = cog;
            this.Rim = rim;
            this.Tire = tire;
        }

        public double GearInches()
        {
            return this.Ratio() * new WheelData(this.Rim, this.Tire).Diameter();
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
            System.Console.WriteLine(new Gear(51, 11, 26, 1.5).GearInches());
        }
    }
}
