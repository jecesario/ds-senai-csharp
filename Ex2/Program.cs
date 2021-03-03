using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Soma dos dois números: " + (n1 + n2));
            Console.WriteLine("Subtração dos dois números: " + (n1 - n2));
            Console.WriteLine("Multiplicação dos dois números: " + (n1 * n2));
            Console.WriteLine("Divisão dos dois números: " + (n1 / n2));
            Console.ReadLine();
        }
    }
}
