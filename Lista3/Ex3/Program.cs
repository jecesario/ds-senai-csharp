using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3 {
    class Program {
        static void Main(string[] args) {

            double a;
            double b;

            Console.Write("Informe um numero positivo: ");
            a = double.Parse(Console.ReadLine());

            while(a <= 0) {
                Console.Write("Informe um numero positivo: ");
                a = double.Parse(Console.ReadLine());
            }

            Console.Write("Informe outro numero positivo: ");
            b = double.Parse(Console.ReadLine());

            while (b <= 0) {
                Console.Write("Informe outro numero positivo: ");
                b = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("O numero " + a + " dividido por " + b + " é igual a " + (a / b));

            Console.ReadLine();

        }
    }
}
