using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1 {
    class Program {
        static void Main(string[] args) {

            String texto = "";

            for(int i=1; i<8; i++) {
                texto += i;
                Console.WriteLine(texto);
            }

            Console.ReadLine();

        }
    }
}
