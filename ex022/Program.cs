// 22) Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua situação em relação ao alistamento militar.
// - Se estiver antes dos 18 anos, mostre em quantos anos faltam para o alistamento.
// - Se já tiver depois dos 18 anos, mostre quantos anos já se passaram do alistamento.

Console.WriteLine("Em que ano você nasceu?");
int anoNasc = int.Parse(Console.ReadLine());
int anoAtual = DateTime.Now.Year;

int idade = anoAtual - anoNasc;
int idadeAlem = idade - 18;

if (idade < 18)
{
    Console.WriteLine("Você ainda não tem idade suficiente para se alistar no exército.");
}
else
{
    Console.WriteLine("Você já poderia se alistar há {0} anos.", idadeAlem);
}