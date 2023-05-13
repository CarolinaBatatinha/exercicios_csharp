// 21) Faça um algoritmo que leia um determinado ano e mostre se ele é ou não BISSEXTO.

Console.WriteLine("Digite um ano e descubra se ele é bissexto:");

int ano = int.Parse(Console.ReadLine());

if (ano % 4 == 0)
{
    Console.WriteLine("O ano {0} é bissexto.", ano);
}
else
{
    Console.WriteLine("O ano {0} não é bissexto.", ano);
}

// Desde a introdução do calendário gregoriano (em 1582), a regra a seguir é usada para determinar o tipo de ano:

// se o número do ano não é divisível por quatro, é um ano comum;
// caso contrário, se o número do ano não for divisível por 100, será um ano bissexto;
// caso contrário, se o número do ano não for divisível por 400, é um ano comum;
// caso contrário, é um ano bissexto.