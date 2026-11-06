# 🔹 TP2: Simulador de Eleição Municipal (Fim do Mundo do Norte)
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


