using System;


namespace AlgoritmosProgramacao.Trabalho01
{
    public class CalculadoraDesconto
    {
        public static void Executar()
        {
            // Programa para uma loja que oferece desconto com base na forma de pagamento e tipo de cliente.
            double ValTotalCompra, ValTotalDesconto, PercentualTotal, PerDescontoBase, PerDescontoaAdici, PerDescontoExtra, ValDescontoBase, ValDescontoAdici, ValDescontoExtra;
            string ForPagamento, TipCliente;


            Console.WriteLine("Informe os seguintes dados:");
            Console.Write("Valor Total da compra: R$");
            ValTotalCompra = double.Parse(Console.ReadLine());
            Console.Write("Forma de pagamento, digite D para dinheiro ou C para cartão: ");
            ForPagamento = Console.ReadLine();
            Console.Write("Tipo de cliente, digite N para cliente normal ou F para cliente fidelidade: ");
            TipCliente = Console.ReadLine();
            Console.WriteLine("Informações sobre os descontos:");


            // Percentual Desconto.
            PerDescontoBase = 0;
            PerDescontoaAdici = 0;
            PerDescontoExtra = 0;
            // Valor Desconto.
            ValDescontoBase = 0;
            ValDescontoAdici = 0;
            ValDescontoExtra = 0;

            //Regras da loja.
            if (ForPagamento == "D") // Pagamento atráves de dinheiro.
            {
                if (ValTotalCompra <= 100) //Desconto de 5%.
                {
                    Console.WriteLine($"Recebe {PerDescontoBase = 5}% de desconto na compra, decontando o valor R${ValDescontoBase = 0.05 * ValTotalCompra}.");
                }
                else //Desconto de 10%.
                {
                    Console.WriteLine($"Recebe {PerDescontoBase = 10}% de desconto na compra, descontando o valor R${ValDescontoBase = 0.10 * ValTotalCompra}.");
                }
            }
            else //Pagamento atráves de Cartão.
            {
                if (ValTotalCompra <= 100)
                {
                    Console.WriteLine($"Desconto de {ValTotalDesconto = 0}%, por causa do valor da compra no cartão.");
                }
                else if (ValTotalCompra <= 300)  // Desconto de 5%.
                {
                    Console.WriteLine($"Recebe {PerDescontoBase = 5}% de desconto na compra, deacontando valor R${ValDescontoBase = 0.05 * ValTotalCompra}.");
                }
                else  // Desconto de 10%.
                {
                    Console.WriteLine($"Recebe {PerDescontoBase = 10}% de desconto na compra, descontando o valor R${ValDescontoBase = 0.10 * ValTotalCompra}.");
                }
            }

            // Regras adcionais.
            if (TipCliente == "F") // Benefício adicional para cliente fidelidade.
            {
                if (ValTotalCompra > 200) //  5% de desconto adicional.
                {
                    Console.WriteLine($"Recebe {PerDescontoaAdici = 5}% de desconto adicional por ser cliente fidelidade, descontando o valor R${ValDescontoAdici = 0.05 * ValTotalCompra}.");
                }
                else  // Cliente fidelidade sem desconto por causa do valor total.
                {
                    Console.WriteLine("Não recebe desconto adicional por causa do valor da compra.");
                }
            }
            else  // Cliente Normal não recebe benefício.
            {
                if (ForPagamento == "D")
                {
                    Console.WriteLine("Não recebe desconto adicional por ser cliente normal.");

                }
                else if (ForPagamento == "C")
                {
                    Console.WriteLine("Não recebe desconto adicional por ser cliente normal.");

                }
            }

            if (ForPagamento == "D" && TipCliente == "F") // 2% de desconto extra por pagar em dinheiro.
            {
                Console.WriteLine($"Por pagar em dinheiro e ser cliente fidelidade recebe {PerDescontoExtra = 2}% de desconto extra, descontando o valor R${ValDescontoExtra = 0.02 * ValTotalCompra}.");
            }
            else if (ForPagamento == "C" && TipCliente == "F") //Pagamento por cartão não recebe desconto extra.
            {
                Console.WriteLine($"Não recebe desconto extra por pagar no cartão.");
            }

            else // Cliente normal não recebe desconto extra independete da forma de pagamento.
            {
                Console.WriteLine($"Não recebe desconto extra por ser cliente normal.");
            }

            // Total do percentual e Total do valor de desconto.
            PercentualTotal = PerDescontoBase + PerDescontoaAdici + PerDescontoExtra;
            ValTotalDesconto = ValDescontoBase + ValDescontoAdici + ValDescontoExtra;

            if (PercentualTotal >= 15) //Limite de desconto 15%.
            {
                Console.WriteLine($"Alcançou o limite máximo de desconto sendo {PercentualTotal = 15}%, o deconto então será de R${ValTotalDesconto = ValDescontoBase + ValDescontoAdici}.");
            }

            // Resultado final da compra e seus descontos.
            Console.WriteLine("Detalhes da Compra:");
            Console.WriteLine($"O valor total da sua compra sem desconto foi de R${ValTotalCompra}.");
            Console.WriteLine($"O percentual de desconto aplicado foi {PercentualTotal}%.");
            Console.WriteLine($"O valor total do desconto aplicado foi R${ValTotalDesconto}.");
            Console.WriteLine($"O valor final a pagar e de R${ValTotalCompra - ValTotalDesconto}.");
        }
    }
}