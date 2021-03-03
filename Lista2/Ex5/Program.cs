using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o preço para dançar um forró: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Informe o dia da semana (1-7): ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("É dia de música aovivo? (S/N): ");
            string aovivo = Console.ReadLine().ToUpper();

            if (dia == 2 || dia == 3 || dia == 5) {
                preco -= 10;
            }

            if (aovivo == "S") {
                preco += 7.5;
            }

            Console.WriteLine("Valor total da entrada: R$" + preco);
            Console.ReadLine();

        }
    }
}
