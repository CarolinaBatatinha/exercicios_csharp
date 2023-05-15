// 27) Crie um programa que leia duas notas de um aluno e calcule a sua média, mostrando uma mensagem no final, de acordo com a média atingida:
// - Média até 4.9: REPROVADO
// - Média entre 5.0 e 6.9: RECUPERAÇÃO
// - Média 7.0 ou superior: APROVADO

Console.WriteLine("Digite sua primeira nota:");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua segunda nota:");
double nota2 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2) / 2;

if (media >= 7.0)
{
    Console.WriteLine("Você foi aprovado! Média final: " + media);
}
else if (media < 7 && media >= 5.0)
{
    Console.WriteLine("Você está na recuperação. Média final: " + media);
}
else
{
    Console.WriteLine("Você está reprovado. Média final: " + media);
}