using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class Gear {
        private int Chainring { get; }
        private int Cog { get; }

        public Gear(int chainring, int cog)
        {
            this.Chainring = chainring;
            this.Cog = cog;
        }

        public double Ratio()
        {
            return this.Chainring / (double)this.Cog;
        }
    }

    class Program {
        /// <summary>
        ///   The main entry point for the application
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            System.Console.WriteLine(new Gear(52, 11).Ratio()); //4.72727272727273
            System.Console.WriteLine(new Gear(30, 27).Ratio()); //1.11111111111111
            return;
        }
    }
}
