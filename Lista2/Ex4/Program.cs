using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());
            Boolean bissexto = false;

            if (ano % 4 == 0) {
                if (ano % 100 != 0) {
                    bissexto = true;
                } else {
                    if (ano % 400 == 0) {
                        bissexto = true;
                    }
                }
            }

            if (bissexto == true) {
                Console.WriteLine("O ano: " + ano + " é bissexto!");
            } else {
                Console.WriteLine("O ano: " + ano + " não é bissexto!");
            }

            Console.ReadLine();

        }
    }
}
