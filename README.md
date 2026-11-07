
<div align="center">


# Algoritmos e Técnicas de Programação (ATP) - PUC Minas

<!-- Badges Principais -->
<p align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#" />
 <img src="https://img.shields.io/badge/Semestre%2F1-2026-95389E?style=for-the-badge"/>
 <img src="https://img.shields.io/badge/License-None-lightgrey?style=for-the-badge" />
</p>
</div>

Repositório consolidado dos Trabalhos Práticos (TPs) desenvolvidos para a disciplina de **Algoritmos e Técnicas de Programação (ATP)** do 1º período do curso de **Sistemas de Informação** da **PUC Minas (Campus Betim)**.

O projeto foi arquitetado em **C# (.NET 8)** de forma totalmente modularizada, centralizando a execução de todos os trabalhos práticos em um menu interativo único no terminal.

---

##  Sobre o Repositório

O objetivo central deste projeto vai além da simples entrega de exercícios avaliativos: ele demonstra a evolução prática no domínio da lógica de programação e da linguagem **C# (.NET 8)**, aplicando conceitos fundamentais de manipulação de dados e persistência em arquivos. Para garantir organização, escalabilidade e manutenibilidade, a solução adota uma **arquitetura modularizada e centralizada**. Todos os trabalhos estão isolados em seus respetivos módulos e são executados a partir de um **menu principal interativo** na raiz (`Program.cs`), simulando um sistema integrado de software.

###  Pilares e Objetivos Técnicos
* **Consolidação Lógica:** Prática intensiva de estruturas condicionais, laços de repetição aninhados, vetores, matrizes e sub-rotinas (funções e procedimentos).
* **Engenharia de Software Aplicada:** Implementação de boas práticas de desenvolvimento desde o primeiro período universitário, incluindo versionamento rigoroso com **Git/GitHub**, uso de **Conventional Commits**, gestão de tarefas via **Issues** e integração contínua (**CI/CD** com GitHub Actions para validação de build e formatação de código).

---

## Estrutura do Repositório

```text
algoritmos-e-tecnicas-de-programacao-puc/
├── .github/
│   └── workflows/
│       └── csharp-ci.yml           # Workflow do GitHub Actions (Format & Build)
├── src/
│   ├── Program.cs                  # Menu centralizador principal da aplicação
│   ├── Atp.csproj                 # Arquivo de configuração do projeto .NET
│   ├── Trabalho01/                # TP1: Calculadora de Descontos
│   │   └── CalculadoraDesconto.cs
│   ├── Trabalho02/                # TP2: Simulador de Eleição
│   │   └── SimuladorEleicao.cs
│   ├── Trabalho03/                # TP3: Monitoramento Climático
│   │   └── SistemaClimatico.cs
│   └── Trabalho04/                # TP4: Eleição com Manipulação de Arquivos
│       ├── SimuladorEleicaoSul.cs
│       ├── eleicao_in.txt         # Arquivo de entrada para leitura dos dados
│       └── eleicao_out.txt        # Arquivo de saída gerado pelo sistema
├── .gitignore                     # Configuração de arquivos ignorados do Git
└── README.md                      # Documentação principal do repositório
```

---

##  Trabalhos Práticos Implementados

---

### 🔹 TP1: Calculadora de Descontos Progressivos
* **Objetivo:** Aplicar estruturas condicionais e regras de decisão acumulativas em C#.
* **Conceitos Aplicados:** Declaração de variáveis, casting, operadores lógicos/aritméticos, instruções `if / else if / else` e formatação de saídas monetárias.

####  Regras de Negócio e Funcionamento
1. **Entrada de Dados:** Solicita o valor total da compra, a forma de pagamento (`1` - Dinheiro/PIX ou `2` - Cartão) e se o cliente faz parte do programa de fidelidade (`1` - Sim ou `2` - Não).
2. **Cálculo Progressivo:**
   * Compras a partir de R$ 100,00 recebem desconto base de 5%.
   * Compras a partir de R$ 300,00 recebem desconto base de 10%.
   * Pagamentos em Dinheiro/PIX adicionam +3% de desconto extra.
   * Clientes do programa de fidelidade recebem +2% de desconto extra.
3. **Teto Máximo:** O desconto total é limitado ao teto máximo de **15%**.
4. **Saída:** Exibe o valor bruto, a porcentagem total de desconto aplicada, o valor economizado e o valor líquido a pagar.

---

### 🔹 TP2: Simulador de Eleição Municipal (Fim do Mundo do Norte)
* **Objetivo:** Dominar estruturas de repetição, controle de fluxo e tratamento de validações de entrada.
* **Conceitos Aplicados:** Laços `while` e `for`, validação contra entradas inválidas/nulas, contagem de votos e laços de repetição condicionados ao desempate.

####  Regras de Negócio e Funcionamento
1. **Validação de Eleitores:** Solicita a quantidade de eleitores `n` e exige obrigatoriamente um valor `n >= 10`, insistindo até o usuário digitar um valor válido.
2. **Cadastro dos Candidatos:** Cadastra os números de identificação dos candidatos Teobaldo e Astrogildo, garantindo que os números sejam maiores que zero e diferentes entre si.
3. **Votação em Turno:** O programa percorre os `n` eleitores registrando cada voto:
   * Voto no número do candidato 1 (Teobaldo).
   * Voto no número do candidato 2 (Astrogildo).
   * Voto `0` computado como **Voto em Branco**.
   * Qualquer outro número computado como **Voto Nulo**.
4. **Regra de Desempate:** Caso a votação termine empatada entre os dois candidatos, o programa exibe o resultado parcial e inicia automaticamente um **novo turno de eleição** com os mesmos `n` eleitores, repetindo o ciclo até que haja um vencedor absoluto.

---

### 🔹 TP3: Sistema de Monitoramento Climático (Centro-Oeste de MG)
* **Objetivo:** Manipular coleções unidimensionais e bidimensionais integradas a uma interface de menu em console.
* **Conceitos Aplicados:** Vetores (`string[]`), Matrizes (`int[,]`), navegação por índices, deslocamento de dados e menu interativo com `switch` e `do-while`.

####  Regras de Negócio e Funcionamento
1. **Inicialização:** Solicita a quantidade `n` de cidades da região Centro-Oeste de Minas Gerais e lê os nomes das cidades para um vetor. Em seguida, inicializa uma matriz de tamanho `n x 8` para registrar o histórico das temperaturas dos últimos 8 dias.
2. **Histórico Deslizante (Shifting):** Ao registrar uma nova temperatura para uma cidade, o sistema desloca todas as medições existentes uma posição para a direita (`Medição 8` recebe `Medição 7`, ..., `Medição 2` recebe `Medição 1`), inserindo o novo dado na `Medição 1` e descartando o registro mais antigo.
3. **Menu Interativo:**
   * **a) Registrar temperatura de uma cidade:** Insere um novo dado aplicando o deslocamento.
   * **b) Exibir temperaturas de uma cidade:** Lista o histórico das 8 medições de uma cidade específica.
   * **c) Exibir temperaturas geral:** Exibe a matriz completa de todas as cidades e medições.
   * **d) Exibir temperatura média de uma cidade:** Calcula e exibe a média aritmética das temperaturas de uma cidade.
   * **e) Exibir temperaturas médias geral:** Calcula e exibe a média de cada uma das cidades cadastradas.
   * **f) Sair:** Encerra a execução do módulo.

---

### 🔹 TP4: Simulador de Eleição Municipal com Manipulação de Arquivos (Fim do Mundo do Sul)
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

--- 

## Fluxo de Trabalho Git 

Todo o desenvolvimento deste repositório seguiu boas práticas do mercado de software:

* Conventional Commits: Padronização nos commits como feat:, docs:, ci: e fix:.

* Branching Strategy: Cada trabalho foi isolado e desenvolvido em sua própria branch feature/.

* Code Review via Pull Requests: Alterações integradas à branch main por meio de PRs vinculados a Issues detalhadas.

--- 


## Como Executar

1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/) instalado na sua máquina.
2.  Clone este repositório:
   
   ```bash
   git clone https://github.com/lauramorgadobastos/algoritmos-e-estrutura-de-dados-puc.git
   
   ```

3. No terminal entre na pasta

 ```bash
  cd .\algoritmos-e-tecnicas-de-programacao-puc/src\
   ```

4. Comando

```bash
   dotnet run   
   ```

5. Navegue pelo Menu Principal:
Digite o número correspondente ao trabalho que deseja testar (1 a 4) ou 0 para encerrar o programa.

---

## Sobre Mim

Desenvolvido por *Laura Morgado Bastos Gomes*  
Estudante de *Sistemas de Informação - PUC Minas*. 

### Conecte-se comigo

Você pode me encontrar nos canais abaixo:


[![Linkedin](https://img.shields.io/badge/LinkedIn-4C1D95?style=for-the-badge&logo=linkedin&logoColor=fff)](https://www.linkedin.com/in/laura-morgado-bastos?)
[![GitHub](https://img.shields.io/badge/GitHub-4C1D95?style=for-the-badge&logo=github&logoColor=fff)](https://github.com/lauramorgadobastos) 
[![Email](https://img.shields.io/badge/Email-4C1D95?style=for-the-badge&logo=gmail&logoColor=fff)](mailto:laura.bastosmorgado27@gmail.com)

---

##  Licença 
Este repositório não possui uma licença específica definida, pois tem caráter estritamente educacional e acadêmico para a disciplina de Algoritmos e Técnicas de Programação (ATP). 
