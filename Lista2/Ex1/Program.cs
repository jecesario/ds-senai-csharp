using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o número de maçãs: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n < 12) {
                Console.WriteLine("Valor de cada maçã: R$1,30 - Valor de todas as maçãs: R$" + (n * 1.3));
            } else {
                Console.WriteLine("Valor de cada maçã: R$1,00 - Valor de todas as maçãs: R$" + n);
            }

            Console.ReadLine();
        }
    }
}
