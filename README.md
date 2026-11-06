
# 🔹 TP3: Sistema de Monitoramento Climático (Centro-Oeste de MG)
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
