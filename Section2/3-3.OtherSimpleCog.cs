using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class Gear {
        private int Cog { get; }
        private double UnanticipatedAdjustmentFactor { get; }
        private int Chainring {
            get {
                return this.Cog * UnanticipatedAdjustmentFactor;
            }
         }
    }
}
