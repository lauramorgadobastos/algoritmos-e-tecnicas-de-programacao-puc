# 🔹 TP4: Simulador de Eleição Municipal com Manipulação de Arquivos (Fim do Mundo do Sul)
* **Objetivo:** Construir um sistema modularizado com persistência de dados em arquivos de texto (I/O).
* **Conceitos Aplicados:** Leitura com `StreamReader`, gravação com `StreamWriter`, caminhos relativos de arquivos, modularização por procedimentos/funções e passagem de parâmetros por referência (`ref`).

#### Regras de Negócio e Funcionamento
1. **Entrada por Arquivo (`eleicao_in.txt`):** O sistema realiza a leitura automatizada dos dados a partir do arquivo texto presente na pasta `src/Trabalho04/eleicao_in.txt`:
   * Quantidade de candidatos (mínimo 3 candidatos).
   * Número e nome de cada candidato.
   * Quantidade de eleitores (mínimo 10 eleitores).
   * Título eleitoral, nome, data de nascimento, idade e o número digitado na urna para cada eleitor.
2. **Apuração Modularizada:** O código é dividido em funções especialistas:
   * `VerificaQuantidadeCandidatos()` e `VerificaQuantidadeEleitores()` para validações.
   * `LerInformacoesCandidatos()` e `LerInformacoesEleitores()` para leitura e contagem dos votos.
   * `ExibirResultadoEleicao()` para calcular o vencedor ou identificar empates.
3. **Saída Dupla (Tela e Arquivo):** Todos os resultados da apuração (vencedor, votos por candidato, brancos, nulos e status) são impressos no terminal e simultaneamente gravados no arquivo `src/Trabalho04/eleicao_out.txt`.
