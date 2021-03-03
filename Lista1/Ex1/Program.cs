using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double imposto = 0.21;
            double valorSemImposto;
            valorSemImposto = 23.5;
            double resultado;
            resultado = imposto * valorSemImposto;
            Console.WriteLine("Valor do imposto: " + resultado);
            Console.ReadLine();
        }
    }
}
