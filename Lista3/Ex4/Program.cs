using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4 {
    class Program {
        static void Main(string[] args) {

            int idade;
            double altura;

            int auxIdade = 0;
            double auxAltura = 0;

            for(int i=0; i<5; i++) {
                Console.Write("Informe a sua idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.Write("Informe a sua altura: ");
                altura = double.Parse(Console.ReadLine());

                if(auxIdade < idade) {
                    auxIdade = idade;
                }

                if(auxAltura < altura) {
                    auxAltura = altura;
                }

                // Para fins de teste
                // Console.WriteLine("Maior idade: " + auxIdade + " - Maior altura: " + auxAltura);

            }

            Console.WriteLine("Maior idade: " + auxIdade);
            Console.WriteLine("Maior altura: " + auxAltura);

            Console.ReadLine();

        }
    }
}
