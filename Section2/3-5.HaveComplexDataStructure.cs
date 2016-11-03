using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class ObscuringReferences {
        private List<int[]> Data { get; }

        public ObscuringReferences(List<int[]> data)
        {
            this.Data = data;
        }

        public double Diameter()
        {
            return this.Data.Aggregate(
                0,
                (sum, cell) => sum + (cell[0] + cell[1] * 2));
        }
    }
}
