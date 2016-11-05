using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class Program {
        /// <summary>
        ///   The main entry point for the application
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            {
                int chainring = 52;
                int cog = 11;
                double ratio = chainring / (double)cog;
                System.Console.WriteLine(ratio);    //4.72727272727273
            }

            {
                int chainring = 30;
                int cog = 27;
                double ratio = chainring / (double)cog;
                System.Console.WriteLine(ratio);    //1.11111111111111
            }

            return;
        }
    }
}
