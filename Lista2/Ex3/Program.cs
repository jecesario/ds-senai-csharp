using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite valor do salário fixo: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Digite valor das vendas: ");
            double totalVendas = double.Parse(Console.ReadLine());

            double comissao = 0;

            if(totalVendas > 0 && totalVendas <= 1500) {
                comissao += totalVendas * 0.03;
            } else if (totalVendas > 1500) {
                comissao += (1500 * 0.03) + (totalVendas - 1500) * 0.05;
            } else {
                Console.WriteLine("Valor informado inválido!");
            }

            Console.WriteLine("Valor do salário: " + salario);
            Console.WriteLine("Valor das vendas: " + totalVendas);
            Console.WriteLine("Valor com comissão: " + (salario + comissao));

            Console.ReadLine();
        }
    }
}
