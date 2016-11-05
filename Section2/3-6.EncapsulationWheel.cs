using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class RevealingReferences {
        private class Wheel {
            public int Rim { get; }
            public int Tire { get; }
            public Wheel(int rim, int tire)
            {
                this.Rim = rim;
                this.Tire = tire;
            }
        }

        private static List<Wheel> Wheelify(List<int[]> data)
        {
            return data
                .Select(cell => new Wheel(cell[0], cell[1]))
                .ToList();
        }

        private List<Wheel> Wheels { get; }

        public RevealingReferences(List<int[]> data)
        {
            this.Wheels = Wheelify(data);
        }

        public double Diameters() {
            return this.Wheels.Aggregate(
                0,
                (sum, wheel) =>
            )
        }
    }
}
