using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pescaria {
    class Program {

        int qtPeixes = 0;
        int qtJogadores = 0;
        string[] nomesJogadores = new string[6];
        int[] pontuacaoJogadores = new int[6];
        int qtIscas = 0;
        string[,] lago = new string[5, 10];
        int linhaNoJogo = 0;
        int colunaNoJogo = 0;
        int vencedor = 0;

        void menu() {

            // Solicitando quantidade de peixes
            Console.Write("Infome o numero de peixes que terá no lago (1-20): ");
            
            qtPeixes = leiaInt();
            // Verificando se o numero de peixes é válido
            while (qtPeixes < 1 || qtPeixes > 20) {
                Console.Write("Infome o numero de peixes *VÁLIDO* que terá no lago (1-20): ");
                qtPeixes = leiaInt();
            }

            // Solicitando quantidade de jogadores
            Console.Write("Informe a quantidade de jogadores (max: 6): ");
            qtJogadores = leiaInt();

            // Verificando se o numero de jogadores é válido
            while (qtJogadores < 1 || qtJogadores > 6) {
                Console.Write("Informe a quantidade *VÁLIDA* de jogadores (max: 6): ");
                qtJogadores = leiaInt();
            }

            // Solicitando os nomes do jogadores
            for (int i = 0; i < qtJogadores; i++) {
                Console.Write("Informe o nome do " + (i + 1) + "° jogador: ");
                nomesJogadores[i] = Console.ReadLine();
            }

            // Solicitando quantidade de iscas
            Console.Write("Informe a quantidade de iscas (max: 3): ");
            qtIscas = leiaInt();

            // Verificando se o numero de iscas é válido
            while (qtIscas < 1 || qtIscas > 3) {
                Console.Write("Informe a quantidade *VÁLIDA* de iscas (max: 3): ");
                qtIscas = leiaInt();
            }

            prencherMatriz();
            criarLago();
            jogar();
        }

        void prencherMatriz() {

            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 10; j++) {
                    lago[i, j] = "livre";
                }
            }

        }

        void criarLago() {

            // Instanciando classe do tipo Random
            Random r = new Random();

            int cont = 0;

            // Preencheendo peixes aleatóriamente
            while (cont < qtPeixes) {
                int l = r.Next(0, 5);
                int c = r.Next(0, 10);
                if (lago[l, c] == "livre") {
                    lago[l, c] = "peixe";
                    cont++;
                }
            }
            
        }

        void exibirLagoNoJogo() {

            Console.WriteLine();

            // Legenda
            Console.WriteLine("Legenda: <x> - Acerto | <-> - Erro | ~~~ - Espaço livre");

            // Exibindo o numero de colunas
            for (int k = 0; k < 10; k++) {
                if (k == 0) {
                    Console.Write("\t " + k + "\t");
                } else {
                    Console.Write(" " + k + "\t");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++) {
                // Exibindo o numero de linhas
                Console.Write(i + "\t");

                // Configurando regras de exibição
                for (int j = 0; j < 10; j++) {
                    if (lago[i, j] == "livre" || lago[i, j] == "peixe") {
                        Console.Write("~~~" + "\t");
                    } else if (lago[i, j] == "erro") {
                        Console.Write("<->" + "\t");
                    } else if (lago[i, j] == "acerto") {
                        Console.Write("<x>" + "\t");
                    }
                }
                Console.WriteLine();
            }
        }

        void exibirLagoNoFimJogo() {

            // Legenda
            Console.WriteLine("Legenda <x> - Acerto | <-> - Erro | ~~~ - Espaço livre | <o> - Peixes não encontrados");

            // Exibindo o numero de colunas
            for (int k = 0; k < 10; k++) {
                if (k == 0) {
                    Console.Write("\t " + k + "\t");
                } else {
                    Console.Write(" " + k + "\t");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++) {
                // Exibindo o numero de linhas
                Console.Write(i + "\t");

                // Configurando regras de exibição
                for (int j = 0; j < 10; j++) {
                    if (lago[i, j] == "livre") {
                        Console.Write("~~~" + "\t");
                    } else if (lago[i, j] == "erro") {
                        Console.Write("<->" + "\t");
                    } else if (lago[i, j] == "acerto") {
                        Console.Write("<x>" + "\t");
                    } else if (lago[i, j] == "peixe") {
                        Console.Write("<o>" + "\t");
                    }
                }
                Console.WriteLine();
            }
        }

        void jogar() {

            int cont = 0;

            while (qtIscas != cont) {
                for (int i = 0; i < qtJogadores; i++) {

                    //Método certo pro jogo ficar bala
                    exibirLagoNoJogo();

                    //Para fins de testes
                    //exibirLagoReal();

                    Console.WriteLine();

                    for (int j = 0; j < qtJogadores; j++) {
                        Console.WriteLine("Pontuação de " + nomesJogadores[j] + ": " + pontuacaoJogadores[j]);
                    }

                        Console.WriteLine("Tentativa: " + (cont + 1));
                        // Solicitando uma linha ao jogador X
                        Console.WriteLine("Jogador: " + nomesJogadores[i]);
                        Console.Write("Informe uma linha: ");
                        linhaNoJogo = leiaInt();
                        // Verificando se foi informado uma linha válida
                        while (linhaNoJogo < 0 || linhaNoJogo > 4) {
                            Console.Write("Informe uma linha *VÁLIDA*: ");
                            linhaNoJogo = leiaInt();
                        }

                        // Solicitando uma coluna ao jogador X
                        Console.WriteLine("Jogador: " + nomesJogadores[i]);
                        Console.Write("Informe uma coluna: ");
                        colunaNoJogo = leiaInt();
                        // Verificando se foi informado uma coluna válida
                        while (colunaNoJogo < 0 || colunaNoJogo > 9) {
                            Console.Write("Informe uma coluna *VÁLIDA*: ");
                            colunaNoJogo = leiaInt();
                        }

                        while (validarLinhaColuna() == false) {
                        Console.WriteLine("\nLinha e coluna já pescadas, escolha outra!\n");

                        exibirLagoNoJogo();

                        Console.WriteLine("Tentativa: " + (cont + 1));
                        // Solicitando uma linha ao jogador X
                        Console.WriteLine("Jogador: " + nomesJogadores[i]);
                        Console.Write("Informe uma linha: ");
                        linhaNoJogo = leiaInt();
                        // Verificando se foi informado uma linha válida
                        while (linhaNoJogo < 0 || linhaNoJogo > 4) {
                            Console.Write("Informe uma linha *VÁLIDA*: ");
                            linhaNoJogo = leiaInt();
                        }

                        // Solicitando uma coluna ao jogador X
                        Console.WriteLine("Jogador: " + nomesJogadores[i]);
                        Console.Write("Informe uma coluna: ");
                        colunaNoJogo = leiaInt();
                        // Verificando se foi informado uma coluna válida
                        while (colunaNoJogo < 0 || colunaNoJogo > 9) {
                            Console.Write("Informe uma coluna *VÁLIDA*: ");
                            colunaNoJogo = leiaInt();
                        }
                    }

                        

                    if (pescar()) {
                        pontuacaoJogadores[i]++;
                    }
                }
                cont++;
            }

            exibirPontuacao();
            exibirLagoNoFimJogo();
            resetarVariaveis();

        }

        Boolean pescar() {

            Boolean resultado = false;

            if (lago[linhaNoJogo, colunaNoJogo] == "peixe") {
                lago[linhaNoJogo, colunaNoJogo] = "acerto";
                resultado = true;
            } else {
                lago[linhaNoJogo, colunaNoJogo] = "erro";
                resultado = false;
            }
            return resultado;
        }

        Boolean validarLinhaColuna() {
            Boolean valido = false;

            if(lago[linhaNoJogo, colunaNoJogo] == "peixe" || lago[linhaNoJogo, colunaNoJogo] == "livre") {
                return true;
            }

            return valido;
        }

        void exibirPontuacao() {

            Console.WriteLine("*** Pontuação dos jogadores ***");
            Console.WriteLine();
            for (int i = 0; i < qtJogadores; i++) {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Jogador: " + nomesJogadores[i]);
                Console.WriteLine("Pontuação: " + pontuacaoJogadores[i]);
            }
            Console.WriteLine();

            definirVencedor();

        }

        int maiorPontuacao() {
            int aux = 0;

            for (int k = 0; k < qtJogadores; k++) {
                if (pontuacaoJogadores[k] > aux) {
                    aux = pontuacaoJogadores[k];
                    vencedor = k;
                }
            }

            return vencedor;
        }

        Boolean verificaEmpate() {
            Boolean empate = false;

            int aux = pontuacaoJogadores[maiorPontuacao()];
            int repetidos = 0;

            for(int i = 1; i < qtJogadores; i++) {
                if(pontuacaoJogadores[i] == aux) {
                    repetidos++;
                } 
            }

            if(repetidos > 0) {
                empate = true;
            } else {
                empate = false;
            }

            return empate;
        }

        void definirVencedor() {

            if (verificaEmpate()) {
                Console.WriteLine("Houve empate, quem ganhou foi o pesqueiro!\n");
            } else {
                Console.WriteLine("Jogador vencedor: " + nomesJogadores[maiorPontuacao()]);
            }
        }

        void resetarVariaveis() {
            for (int i = 0; i < 6; i++) {
                pontuacaoJogadores[i] = 0;
            }
        }

        // Método hack para fins de teste
        void exibirLagoReal() {

            // Exibindo o numero de colunas
            for (int k = 0; k < 10; k++) {
                if (k == 0) {
                    Console.Write("\t " + k + "\t");
                } else {
                    Console.Write(" " + k + "\t");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++) {
                // Exibindo o numero de linhas
                Console.Write(i + "\t");

                for (int j = 0; j < 10; j++) {
                    Console.Write(lago[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Teste para verificar numeros random, foi constatado que usar duas instancias no mesmo método dá ruim!
        void test() {
            Random r = new Random();
            Random r2 = new Random();

            for(int i = 0; i < 20; i++) {
                Console.WriteLine(i + " - " + r.Next(0, 5) + " - " + r2.Next(0, 10));
            }
        }

        int leiaInt () {
            int numero;
            while(!int.TryParse(Console.ReadLine(), out numero)) {
                Console.Write("Digite um número inteiro: ");
            }
            return numero;
        }

        static void Main(string[] args) {

            Program run = new Program();

            run.menu();

            Console.ReadLine();
        }
    }
}
