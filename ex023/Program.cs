// 23) Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos para todos, mas especialmente para mulheres. Faça um programa que leia nome, sexo e o valor das compras do cliente e calcule o preço com desconto. Sabendo que:
// - Homens ganham 5% de desconto
// - Mulheres ganham 13% de desconto

Console.WriteLine("Sexo do cliente: ");
string sexoCliente = Console.ReadLine();

Console.WriteLine("Qual o valor da compra?");
double valor = double.Parse(Console.ReadLine());

if (sexoCliente == "feminino")
{
    double valorDescFem = valor - (valor * 0.13);
    Console.WriteLine("O valor da cliente é igual a R${0}.", valorDescFem);
}
else if (sexoCliente == "masculino")
{
    double valorDescMasc = valor - (valor * 0.05);
    Console.WriteLine("O cliente vai pagar R${0}.", valorDescMasc);
}
else
{
    Console.WriteLine("Sexo inválido!");
    return;
}