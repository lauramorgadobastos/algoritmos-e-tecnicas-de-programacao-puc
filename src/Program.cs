using System;

namespace AlgoritmosProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("======================================================");
                Console.WriteLine("    Curso: Sistemas de Informação (1º Período)        ");
                Console.WriteLine("    Disciplina: Algoritmos e Técnicas de Programação");
                Console.WriteLine("======================================================");
                Console.WriteLine("Selecione o trabalho que deseja executar:");
                Console.WriteLine("1 - Trabalho Prático 1: Calculadora de Descontos");
                Console.WriteLine("2 - Trabalho Prático 2 (Em breve)");
                Console.WriteLine("3 - Trabalho Prático 3 (Em breve)");
                Console.WriteLine("4 - Trabalho Prático 4 (Em breve)");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("======================================================");
                Console.Write("Digite sua opção: ");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            AlgoritmosProgramacao.Trabalho01.CalculadoraDesconto.Executar();
                            break;
                        case 2:
                            AlgoritmosProgramacao.Trabalho02.SimuladorEleicao.Executar();
                            break;
                        case 3:
                            Console.WriteLine("\n[Em breve] O Trabalho 3 ainda será adicionado.");
                            Pausar();
                            break;
                        case 4:
                            Console.WriteLine("\n[Em breve] O Trabalho 4 ainda será adicionado.");
                            Pausar();
                            break;
                        case 0:
                            Console.WriteLine("\nEncerrando o programa. Até mais!!");
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida! Tente novamente.");
                            Pausar();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Digite um número correspondente ao menu.");
                    Pausar();
                }

            } while (opcao != 0);
        }
        static void Pausar()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

    }
}