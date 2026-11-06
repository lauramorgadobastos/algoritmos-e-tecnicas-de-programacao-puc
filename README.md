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

