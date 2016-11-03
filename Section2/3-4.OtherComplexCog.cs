using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class Gear {
        private int Chainring {
            get {
                return this.Cog * (this.Foo ? BarAdjustment : BazAdjustment));
            }
         }
        private int Cog { get; }
        private bool Foo { get; }
        private double BarAdjustment { get; }
        private double BazAdjustment { get; }
    }
}
