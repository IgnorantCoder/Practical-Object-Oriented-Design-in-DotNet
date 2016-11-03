using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class Gear {
        private int chainring_;
        private int cog_;

        public Gear(int chainring, int cog)
        {
            this.chainring_ = chainring;
            this.cog_ = cog;
        }

        public double Ratio()
        {
            return this.chainring_ / (double)this.cog_;
        }
    }
}
