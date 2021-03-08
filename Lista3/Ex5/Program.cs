using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5 {
    class Program {
        static void Main(string[] args) {

            Boolean continua = true;
            double soma = 0;
            int contador = 0;

            while(continua) {
                Console.Write("Informe a nota do Aluno (-1 para sair): ");
                double nota = double.Parse(Console.ReadLine());
                if (nota < 0) {
                    continua = false;
                } else {
                    soma += nota;
                    contador++;
                }
                // Para fins de teste
                // Console.WriteLine("Soma das notas: " + soma + " - Média: " + (soma / contador));
            }
            Console.WriteLine("Soma das notas: " + soma);
            Console.WriteLine("Quantidade de notas: " + contador);
            Console.WriteLine("Média: " + (soma / contador));

            Console.ReadLine();

        }
    }
}
