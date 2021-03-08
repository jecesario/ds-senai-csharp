using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2 {
    class Program {
        static void Main(string[] args) {

            for (int i = 1; i <= 7; i++) {
                for (int x = 1; x <= 7; x++) {
                    if (x <= i) {
                        Console.Write(x);
                    } else {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
