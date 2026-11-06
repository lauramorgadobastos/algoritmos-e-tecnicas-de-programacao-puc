using System;

namespace AlgoritmosProgramacao.Trabalho03
{
    public class SistemaClimatico
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("  Sistema de Monitoramento Climático ");
            Console.WriteLine("----------------------------------------------");

            int n, i, j, temperatura, soma;
            string nomeCid;
            string[] cidade;
            int[,] medicao;
            double[] media;
            string opcao;

            // a) Leitura do número de cidades
            Console.Write("Informe o número de cidades envolvidas: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Número inválido. Informe um valor maior que 0: ");
            }

            cidade = new string[n];
            medicao = new int[n, 8];
            media = new double[n];

            // b) Leitura dos nomes das cidades
            Console.WriteLine("\nCadastro de Cidades:");
            for (i = 0; i < n; i++)
            {
                Console.Write($"Informe o nome da {i + 1}° cidade: ");
                cidade[i] = Console.ReadLine();
            }

            // c) Menu de Opções
            do
            {
                Console.WriteLine("\n=======================================================");
                Console.WriteLine("                     MENU DE OPÇÕES                    ");
                Console.WriteLine("=======================================================");
                Console.WriteLine("a) Registrar temperatura de uma cidade");
                Console.WriteLine("b) Exibir temperaturas de uma cidade");
                Console.WriteLine("c) Exibir temperaturas geral");
                Console.WriteLine("d) Exibir temperatura média de uma cidade");
                Console.WriteLine("e) Exibir temperaturas médias geral");
                Console.WriteLine("f) Sair");
                Console.WriteLine("=======================================================");
                Console.Write("Informe a opção desejada: ");
                opcao = Console.ReadLine()?.ToLower().Trim();
                Console.WriteLine();

                switch (opcao)
                {
                    case "a":
                        Console.Write("Informe o nome da cidade: ");
                        nomeCid = Console.ReadLine();
                        i = 0;
                        while ((i < cidade.Length) && (nomeCid != cidade[i]))
                        {
                            i++;
                        }

                        if (i < cidade.Length)
                        {
                            // Desloca as medições para a direita (regra de negócio: novo registro na Medição 1)
                            for (j = 7; j > 0; j--)
                            {
                                medicao[i, j] = medicao[i, j - 1];
                            }

                            Console.Write("Informe a temperatura da cidade: ");
                            while (!int.TryParse(Console.ReadLine(), out temperatura))
                            {
                                Console.Write("Temperatura inválida. Digite um número inteiro: ");
                            }
                            medicao[i, 0] = temperatura;
                            Console.WriteLine("Temperatura registrada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("A cidade informada não existe no cadastro.");
                        }
                        break;

                    case "b":
                        Console.Write("Informe o nome da cidade: ");
                        nomeCid = Console.ReadLine();
                        i = 0;
                        while ((i < cidade.Length) && (nomeCid != cidade[i]))
                        {
                            i++;
                        }

                        if (i < cidade.Length)
                        {
                            Console.Write($"{cidade[i]}: ");
                            for (j = 0; j < medicao.GetLength(1); j++)
                            {
                                Console.Write($"{medicao[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("A cidade informada não existe no cadastro.");
                        }
                        break;

                    case "c":
                        Console.WriteLine("--- Tabela Geral de Temperaturas ---");
                        for (i = 0; i < medicao.GetLength(0); i++)
                        {
                            Console.Write($"{cidade[i]}: ");
                            for (j = 0; j < medicao.GetLength(1); j++)
                            {
                                Console.Write($"{medicao[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "d":
                        Console.Write("Informe o nome da cidade: ");
                        nomeCid = Console.ReadLine();
                        i = 0;
                        while ((i < cidade.Length) && (nomeCid != cidade[i]))
                        {
                            i++;
                        }

                        if (i < cidade.Length)
                        {
                            soma = 0;
                            for (j = 0; j < medicao.GetLength(1); j++)
                            {
                                soma += medicao[i, j];
                            }
                            media[i] = (double)soma / medicao.GetLength(1);
                            Console.WriteLine($"{cidade[i]} - Média das temperaturas: {media[i]:F2}");
                        }
                        else
                        {
                            Console.WriteLine("A cidade informada não existe no cadastro.");
                        }
                        break;

                    case "e":
                        Console.WriteLine("--- Temperatura Média Geral por Cidade ---");
                        for (i = 0; i < medicao.GetLength(0); i++)
                        {
                            soma = 0;
                            for (j = 0; j < medicao.GetLength(1); j++)
                            {
                                soma += medicao[i, j];
                            }
                            media[i] = (double)soma / medicao.GetLength(1);
                            Console.WriteLine($"{cidade[i]} - Média: {media[i]:F2}");
                        }
                        break;

                    case "f":
                        Console.WriteLine("Encerrando o sistema climático...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Escolha uma opção entre 'a' e 'f'.");
                        break;
                }

                if (opcao != "f")
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != "f");

            Pausar();
        }

        static void Pausar()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }
    }
}