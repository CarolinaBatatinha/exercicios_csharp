// 12) Crie um programa que leia o preço de um produto, calcule e mostre o seu PREÇO PROMOCIONAL, com 5% de desconto.

Console.WriteLine("Digite o preço do produto sem desconto em reais: ");
double valorBruto = double.Parse(Console.ReadLine());
double valorDesconto = valorBruto - (valorBruto * 0.05);

Console.WriteLine("O valor normal do produto é de R$ {0} e, com 5% de desconto, o valor cai para R$ {1}.", valorBruto, valorDesconto);