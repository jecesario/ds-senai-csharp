using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double a = double.Parse(Console.ReadLine());
            a -= a * 0.085;
            Console.WriteLine("Valor com desconto de 8,5%: " + a);

            Console.Write("Digite outro número: ");
            double b = double.Parse(Console.ReadLine());
            b += b * 0.15;
            Console.WriteLine("Valor com acrescimo de 15%: " + b);

            Console.ReadLine();
        }
    }
}
