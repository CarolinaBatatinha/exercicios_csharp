//33) Escreva um programa para aprovar ou não o empréstimo bancário para a compra de uma casa. O programa vai perguntar o valor da casa, o salário do comprador e em quantos anos ele vai pagar. Calcule o valor da prestação mensal, sabendo que ela não pode exceder 30% do salário ou então o empréstimo será negado.

Console.WriteLine("Qual o valor do imóvel que você deseja comprar? ");
double valorImovel = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quanto você recebe de salário? ");
double salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Em quantos anos você pretende pagar o financiamento? ");
double anosPagando = Convert.ToDouble(Console.ReadLine());

double valorParcela = valorImovel/ (anosPagando*12);

if (valorParcela <= (salario * 0.3)) 
{
    Console.WriteLine("Parabéns, você está apto para pedir o financiamento!");
    Console.WriteLine($"Você poderá pagar R$ {valorParcela:F2} por mês durante {anosPagando} anos.");
}
else 
{
    Console.WriteLine("Você não está apto para assumir o financiamento.");
}
