// 19) Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua média e mostre na tela. No final, analise a média e mostre se o aluno teve ou não um bom aproveitamento (se ficou acima da média 7.0).

Console.WriteLine("Qual foi a sua primeira nota?");
double primeiraNota = double.Parse(Console.ReadLine());
Console.WriteLine("Qual foi a sua segunda nota?");
double segundaNota = double.Parse(Console.ReadLine());

double media = (primeiraNota + segundaNota) / 2;

if (media >= 7.0) {
    Console.WriteLine("Parabéns, você está aprovado!");
}
else
{
    Console.WriteLine("Sua média foi insuficiente. Estude mais da próxima vez.");
}