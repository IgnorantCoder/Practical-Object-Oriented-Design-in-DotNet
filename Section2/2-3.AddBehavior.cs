using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class Gear {
        private int Chainring { get; }
        private int Cog { get; }
        private int Rim { get; }
        private int Tire { get; }

        public Gear(int cahinring, int cog, int rim, int tire)
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
            return this.Ratio() * (this.Rim + (this.Tire * 2.0));
        }
    }

    class Program {
        static void Main(string[] args) {
            System.Console.WriteLine(new Gear(52, 11, 26, 1.5).GearInches()); //137.090909090909
            System.Console.WriteLine(new Gear(52, 11, 24, 1.25).GearInches()); //125.272727272727
            return;
        }
    }
}
