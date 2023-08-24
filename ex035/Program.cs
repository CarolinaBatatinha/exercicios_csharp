// 35) Uma empresa de aluguel de carros precisa cobrar pelos seus serviços. O aluguel de um carro custa R$90 por dia para carro popular e R$150 por dia para carro de luxo. Além disso, o cliente paga por Km percorrido. Faça um programa que leia o tipo de carro alugado (popular ou luxo), quantos dias de aluguel e quantos Km foram percorridos. No final mostre o preço a ser pago de acordo com a tabela a seguir:
// - Carros populares (aluguel de R$90 por dia)
// - Até 100Km percorridos: R$0,20 por Km
// - Acima de 100Km percorridos: R$0,10 por Km
// - Carros de luxo (aluguel de R$150 por dia)
// - Até 200Km percorridos: R$0,30 por Km
// - Acima de 200Km percorridos: R$0,25 por Km

using System;

namespace AluguelCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis
            string tipoCarro;
            int diasAluguel, kmPercorridos;
            double precoDia, precoKm, precoTotal;

            // Leitura dos dados de entrada
            Console.WriteLine("Informe o tipo de carro (popular ou luxo): ");
            tipoCarro = Console.ReadLine();

            Console.WriteLine("Informe o número de dias de aluguel: ");
            diasAluguel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o número de Km percorridos: ");
            kmPercorridos = Convert.ToInt32(Console.ReadLine());

            // Cálculo do preço do aluguel
            if (tipoCarro == "popular")
            {
                precoDia = 90;
                if (kmPercorridos <= 100)
                {
                    precoKm = 0.20;
                }
                else
                {
                    precoKm = 0.10;
                }
            }
            else // tipoCarro == "luxo"
            {
                precoDia = 150;
                if (kmPercorridos <= 200)
                {
                    precoKm = 0.30;
                }
                else
                {
                    precoKm = 0.25;
                }
            }

            precoTotal = diasAluguel * precoDia + kmPercorridos * precoKm;

            // Exibição do resultado
            Console.WriteLine($"O preço total do aluguel é de R$ {precoTotal:F2}.");
        }
    }
}

