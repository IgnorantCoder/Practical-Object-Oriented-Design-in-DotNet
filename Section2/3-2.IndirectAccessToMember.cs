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
}
