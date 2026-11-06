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
                Console.WriteLine("    Curso: Sistemas de Informação (1º Período)");
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
                            ExecutarTrabalho1();
                            break;
                        case 2:
                            Console.WriteLine("\n[Em breve] O Trabalho 2 ainda será adicionado.");
                            Pausar();
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
                            Console.WriteLine("\nEncerrando o programa. Até mais!");
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

        // ==========================================
        // TRABALHO PRÁTICO 1
        // ==========================================
        static void ExecutarTrabalho1()
        {
            Console.Clear();
            Console.WriteLine("--- EXECUTANDO: TRABALHO PRÁTICO 1 ---\n");

            double ValTotalCompra, ValTotalDesconto, PercentualTotal, PerDescontoBase, PerDescontoaAdici, PerDescontoExtra, ValDescontoBase, ValDescontoAdici, ValDescontoExtra;
            string ForPagamento, TipCliente;

            Console.WriteLine("Informe os seguintes dados:");
            Console.Write("Valor Total da compra: R$");
            ValTotalCompra = double.Parse(Console.ReadLine());
            Console.Write("Forma de pagamento, digite D para dinheiro ou C para cartão: ");
            ForPagamento = Console.ReadLine().ToUpper();
            Console.Write("Tipo de cliente, digite N para cliente normal ou F para cliente fidelidade: ");
            TipCliente = Console.ReadLine().ToUpper();
            Console.WriteLine("\nInformações sobre os descontos:");

            PerDescontoBase = 0;
            PerDescontoaAdici = 0;
            PerDescontoExtra = 0;
            ValDescontoBase = 0;
            ValDescontoAdici = 0;
            ValDescontoExtra = 0;

            if (ForPagamento == "D")
            {
                if (ValTotalCompra <= 100)
                {
                    Console.WriteLine($"Recebe {PerDescontoBase = 5}% de desconto na compra, descontando o valor R${ValDescontoBase = 0.05 * ValTotalCompra:F2}.");
                }
                else
                {
                    Console.WriteLine($"Recebe {PerDescontoBase = 10}% de desconto na compra, descontando o valor R${ValDescontoBase = 0.10 * ValTotalCompra:F2}.");
                }
            }
            else
            {
                if (ValTotalCompra <= 100)
                {
                    Console.WriteLine($"Desconto de 0%, por causa do valor da compra no cartão.");
                }
                else if (ValTotalCompra <= 300)
                {
                    Console.WriteLine($"Recebe {PerDescontoBase = 5}% de desconto na compra, descontando valor R${ValDescontoBase = 0.05 * ValTotalCompra:F2}.");
                }
                else
                {
                    Console.WriteLine($"Recebe {PerDescontoBase = 10}% de desconto na compra, descontando o valor R${ValDescontoBase = 0.10 * ValTotalCompra:F2}.");
                }
            }

            if (TipCliente == "F")
            {
                if (ValTotalCompra > 200)
                {
                    Console.WriteLine($"Recebe {PerDescontoaAdici = 5}% de desconto adicional por ser cliente fidelidade, descontando o valor R${ValDescontoAdici = 0.05 * ValTotalCompra:F2}.");
                }
                else
                {
                    Console.WriteLine("Não recebe desconto adicional por causa do valor da compra.");
                }
            }
            else
            {
                Console.WriteLine("Não recebe desconto adicional por ser cliente normal.");
            }

            if (ForPagamento == "D" && TipCliente == "F")
            {
                Console.WriteLine($"Por pagar em dinheiro e ser cliente fidelidade recebe {PerDescontoExtra = 2}% de desconto extra, descontando o valor R${ValDescontoExtra = 0.02 * ValTotalCompra:F2}.");
            }
            else
            {
                Console.WriteLine("Não recebe desconto extra.");
            }

            PercentualTotal = PerDescontoBase + PerDescontoaAdici + PerDescontoExtra;
            ValTotalDesconto = ValDescontoBase + ValDescontoAdici + ValDescontoExtra;

            if (PercentualTotal >= 15)
            {
                PercentualTotal = 15;
                ValTotalDesconto = ValDescontoBase + ValDescontoAdici;
                Console.WriteLine($"Alcançou o limite máximo de desconto sendo 15%.");
            }

            Console.WriteLine("\n--- Detalhes da Compra ---");
            Console.WriteLine($"O valor total da sua compra sem desconto foi de R${ValTotalCompra:F2}.");
            Console.WriteLine($"O percentual de desconto aplicado foi {PercentualTotal}%.");
            Console.WriteLine($"O valor total do desconto aplicado foi R${ValTotalDesconto:F2}.");
            Console.WriteLine($"O valor final a pagar é de R${ValTotalCompra - ValTotalDesconto:F2}.");

            Pausar();
        }

        static void Pausar()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}