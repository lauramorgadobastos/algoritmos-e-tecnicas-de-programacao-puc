using System;
using System.IO;

namespace AlgoritmosProgramacao.Trabalho04
{
    public class SimuladorEleicaoSul
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("  Simulador de Eleição - Fim do Mundo do Sul (Leitura por Arquivo) ");
            Console.WriteLine("-------------------------------------------------------------------------------");

            // Configuração dos arquivos de entrada e saída
            StreamReader arqEntrada = new StreamReader("Trabalho04/eleicao_in.txt");
            StreamWriter arqSaida = new StreamWriter("Trabalho04/eleicao_out.txt");

            // 1. Quantidade de candidatos (mínimo 3)
            int n = int.Parse(arqEntrada.ReadLine());
            n = VerificaQuantidadeCandidatos(n, arqEntrada);

            // 2. Informações dos candidatos
            int[] numerosCandi = new int[n];
            string[] nomesCandi = new string[n];
            LerInformacoesCandidatos(numerosCandi, nomesCandi, arqEntrada);

            // 3. Quantidade de eleitores (mínimo 10)
            int m = int.Parse(arqEntrada.ReadLine());
            m = VerificaQuantidadeEleitores(m, arqEntrada);

            // 4. Informações dos eleitores e apuração dos votos
            int[] titulosEleitoral = new int[m];
            string[] nomesEleitores = new string[m];
            string[] datasNascimento = new string[m];
            int[] idadesEleitores = new int[m];
            int[] votCandidatos = new int[n];
            int votBranco = 0;
            int votNulo = 0;

            LerInformacoesEleitores(titulosEleitoral, nomesEleitores, datasNascimento, idadesEleitores, votCandidatos, ref votBranco, ref votNulo, numerosCandi, arqEntrada);

            // 5. Exibição e gravação dos resultados
            ExibirResultadoEleicao(n, nomesCandi, numerosCandi, votCandidatos, votBranco, votNulo, arqSaida);

            // Fechamento dos fluxos de arquivo
            arqEntrada.Close();
            arqSaida.Close();

            Console.WriteLine("\nProcessamento concluído com sucesso!");
            Console.WriteLine("Os resultados foram exibidos acima e salvos no arquivo 'eleicao_out.txt'.");
            Pausar();
        }

        // Validação da quantidade de candidatos
        static int VerificaQuantidadeCandidatos(int n, StreamReader arqEntrada)
        {
            int candidatos = n;
            while (candidatos < 3)
            {
                candidatos = int.Parse(arqEntrada.ReadLine());
            }
            return candidatos;
        }

        // Leitura de número e nome dos candidatos
        static void LerInformacoesCandidatos(int[] numerosCandi, string[] nomesCandi, StreamReader arqEntrada)
        {
            for (int i = 0; i < numerosCandi.Length; i++)
            {
                numerosCandi[i] = int.Parse(arqEntrada.ReadLine());
                nomesCandi[i] = arqEntrada.ReadLine();
            }
        }

        // Validação da quantidade de eleitores
        static int VerificaQuantidadeEleitores(int m, StreamReader arqEntrada)
        {
            int eleitores = m;
            while (eleitores < 10)
            {
                eleitores = int.Parse(arqEntrada.ReadLine());
            }
            return eleitores;
        }

        // Leitura dos eleitores e contabilização dos votos
        static void LerInformacoesEleitores(int[] titulosEleitoral, string[] nomesEleitores, string[] datasNascimento, int[] idadesEleitores, int[] votCandidatos, ref int votBranco, ref int votNulo, int[] numerosCandi, StreamReader arqEntrada)
        {
            for (int i = 0; i < titulosEleitoral.Length; i++)
            {
                titulosEleitoral[i] = int.Parse(arqEntrada.ReadLine());
                nomesEleitores[i] = arqEntrada.ReadLine();
                datasNascimento[i] = arqEntrada.ReadLine();
                idadesEleitores[i] = int.Parse(arqEntrada.ReadLine());

                int voto = int.Parse(arqEntrada.ReadLine());

                if (voto == 0)
                {
                    votBranco++;
                }
                else
                {
                    bool encontrado = false;
                    for (int j = 0; j < numerosCandi.Length; j++)
                    {
                        if (voto == numerosCandi[j])
                        {
                            votCandidatos[j]++;
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        votNulo++;
                    }
                }
            }
        }

        // Apuração e exibição/gravação do resultado
        static void ExibirResultadoEleicao(int n, string[] nomesCandi, int[] numerosCandi, int[] votCandidatos, int votBranco, int votNulo, StreamWriter arqSaida)
        {
            EscreverAmbos("\n=======================================================", arqSaida);
            EscreverAmbos("       RESULTADO DA ELEIÇÃO - FIM DO MUNDO DO SUL      ", arqSaida);
            EscreverAmbos("=======================================================\n", arqSaida);

            int votVencedor = 0;
            int numVencedor = 0;
            string nomeVencedor = "";
            bool empate = false;

            for (int i = 0; i < n; i++)
            {
                if (votCandidatos[i] > votVencedor)
                {
                    votVencedor = votCandidatos[i];
                    numVencedor = numerosCandi[i];
                    nomeVencedor = nomesCandi[i];
                    empate = false;
                }
                else if (votCandidatos[i] == votVencedor && votVencedor > 0)
                {
                    empate = true;
                }
            }

            if (empate)
            {
                EscreverAmbos("Aviso: Houve um empate na eleição entre os candidatos!\n", arqSaida);
                for (int i = 0; i < n; i++)
                {
                    EscreverAmbos($"Candidato {nomesCandi[i]} (n° {numerosCandi[i]}): {votCandidatos[i]} voto(s)", arqSaida);
                }
                EscreverAmbos($"Votos em branco: {votBranco}", arqSaida);
                EscreverAmbos($"Votos nulos: {votNulo}", arqSaida);
                EscreverAmbos("\nStatus: Necessário realizar uma nova eleição.", arqSaida);
            }
            else
            {
                EscreverAmbos($" Vencedor: {nomeVencedor} (n° {numVencedor}) com {votVencedor} votos!\n", arqSaida);
                for (int i = 0; i < n; i++)
                {
                    EscreverAmbos($"Candidato {nomesCandi[i]} (n° {numerosCandi[i]}): {votCandidatos[i]} voto(s)", arqSaida);
                }
                EscreverAmbos($"Votos em branco: {votBranco}", arqSaida);
                EscreverAmbos($"Votos nulos: {votNulo}", arqSaida);
            }
            EscreverAmbos("=======================================================", arqSaida);
        }

        // Função auxiliar para escrever simultaneamente no console e no arquivo de saída
        static void EscreverAmbos(string texto, StreamWriter arqSaida)
        {
            Console.WriteLine(texto);
            arqSaida.WriteLine(texto);
        }

        static void Pausar()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }
    }
}