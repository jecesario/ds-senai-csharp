using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("Valor de B: " + b);

            int aux = a;
            a = b;
            b = aux;

            Console.WriteLine("----------------");

            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("Valor de B: " + b);
            Console.ReadLine();
        }
    }
}
