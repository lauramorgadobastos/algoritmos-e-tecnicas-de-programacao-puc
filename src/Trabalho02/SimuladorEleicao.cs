using System;

namespace AlgoritmosProgramacao.Trabalho02
{
    public class SimuladorEleicao // Trabalho 2
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Simulação da eleição para prefeito na cidade de Fim do Mundo do Norte");
            Console.WriteLine("Candidatos: Teobaldo e Astrogildo");
            Console.WriteLine("--------------------------------------------------------------------------------");

            int n, cadi1, cadi2, numElei = 1;
            int votCadi1 = 0, votCadi2 = 0, votNulo = 0, votBranco = 0;

            // a) Leitura e validação do número de eleitores (mínimo 10)
            Console.Write("Informe o número de eleitores (mínimo 10): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 10)
            {
                Console.Write("Número de eleitores inválido, informe um número maior ou igual a 10: ");
            }

            // b) Leitura do número do candidato 1 (Teobaldo)
            Console.Write("Informe o número do candidato Teobaldo: ");
            while (!int.TryParse(Console.ReadLine(), out cadi1) || cadi1 <= 0)
            {
                Console.Write("Número inválido, informe um número maior que 0: ");
            }

            // b) Leitura do número do candidato 2 (Astrogildo) com validação de duplicidade
            Console.Write("Informe o número do candidato Astrogildo: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out cadi2) && cadi2 > 0 && cadi2 != cadi1)
                {
                    break;
                }
                Console.Write("Número inválido ou repetido. Informe um número maior que 0 e diferente de Teobaldo: ");
            }

            Console.WriteLine("-------------------------------------------------------");

            // Laço para repetir a eleição caso haja empate
            bool houveEmpate = true;

            while (houveEmpate)
            {
                Console.WriteLine($"\n--- {numElei}° Turno / Eleição ---");
                votCadi1 = 0;
                votCadi2 = 0;
                votNulo = 0;
                votBranco = 0;

                // c) Leitura do voto de cada um dos n eleitores
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Informe o voto do {i + 1}° eleitor: ");
                    int votoAtual;
                    while (!int.TryParse(Console.ReadLine(), out votoAtual))
                    {
                        Console.Write($"Entrada inválida. Informe novamente o voto do {i + 1}° eleitor: ");
                    }

                    if (votoAtual == cadi1)
                    {
                        votCadi1++;
                    }
                    else if (votoAtual == cadi2)
                    {
                        votCadi2++;
                    }
                    else if (votoAtual == 0)
                    {
                        votBranco++;
                    }
                    else
                    {
                        votNulo++;
                    }
                }

                // Exibição do resultado parcial
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Resultado parcial de votos da {numElei}° eleição:");
                Console.WriteLine($"Votos Teobaldo ({cadi1}): {votCadi1}");
                Console.WriteLine($"Votos Astrogildo ({cadi2}): {votCadi2}");
                Console.WriteLine($"Votos em branco: {votBranco}");
                Console.WriteLine($"Votos nulos: {votNulo}");
                Console.WriteLine("-------------------------------------------------------");

                // d) Verificação de empate
                if (votCadi1 == votCadi2)
                {
                    Console.WriteLine("Empate detectado! Uma nova eleição será realizada...\n");
                    numElei++;
                }
                else
                {
                    houveEmpate = false; // Encerra o loop pois houve um vencedor
                }
            }

            // Resultado final da eleição
            Console.WriteLine("\n=======================================================");
            Console.WriteLine("              RESULTADO FINAL DA ELEIÇÃO               ");
            Console.WriteLine("=======================================================");
            if (votCadi1 > votCadi2)
            {
                Console.WriteLine($"Ganhador: Teobaldo com {votCadi1} votos!");
                Console.WriteLine($"Total de votos do adversário (Astrogildo): {votCadi2}");
            }
            else
            {
                Console.WriteLine($"Ganhador: Astrogildo com {votCadi2} votos!");
                Console.WriteLine($"Total de votos do adversário (Teobaldo): {votCadi1}");
            }
            Console.WriteLine($"Total de votos em branco: {votBranco}");
            Console.WriteLine($"Total de votos nulos: {votNulo}");
            Console.WriteLine("=======================================================");

            Pausar();
        }

        static void Pausar()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}