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
                Console.WriteLine("===========================================================");
                Console.WriteLine("    Curso: Sistemas de Informação (1º Período)        ");
                Console.WriteLine("    Disciplina: Algoritmos e Técnicas de Programação");
                Console.WriteLine("===========================================================");
                Console.WriteLine("Selecione o trabalho que deseja executar:");
                Console.WriteLine("1 - TP1: Calculadora de Descontos");
                Console.WriteLine("2 - TP2: Eleição Prefeito (Fim do Mundo do Norte)");
                Console.WriteLine("3 - TP3: Sistema de Monitoramento Climático");
                Console.WriteLine("4 - TP4: Eleição Prefeito (Fim do Mundo do Sul - Arquivos)");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("===========================================================");
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
                            AlgoritmosProgramacao.Trabalho03.SistemaClimatico.Executar();
                            break;
                        case 4:
                            AlgoritmosProgramacao.Trabalho04.SimuladorEleicaoSul.Executar();
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