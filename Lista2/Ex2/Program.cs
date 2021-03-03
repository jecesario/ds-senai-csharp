using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            int c = int.Parse(Console.ReadLine());

            if(a > b && a > c) {
                Console.WriteLine("O maior numero é: " + a);
            } else if(b > c) {
                Console.WriteLine("O maior numero é: " + b);
            } else {
                Console.WriteLine("O maior numero é: " + c);
            }

            Console.ReadLine();
        }
    }
}
