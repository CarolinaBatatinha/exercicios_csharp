//9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45.

Console.WriteLine("Quantos reais você tem na carteira? ");
double dinReal = double.Parse(Console.ReadLine());
double dinDolar = dinReal/3.45;

Console.WriteLine($"Você tem R$ {dinReal:F2} e pode comprar US$ {dinDolar:F2}.");
