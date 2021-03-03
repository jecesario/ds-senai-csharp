using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("A raiz quadrada de " + n1 + " é igual a " + Math.Sqrt(n1));
            Console.ReadLine();
        }
    }
}
