// 18) Faça um programa que leia o ano de nascimento de uma pessoa, calcule a idade dela e depois mostre se ela pode ou não votar.

Console.WriteLine("Qual a sua idade?");
int anoNascUsuario = int.Parse(Console.ReadLine());
int anoAtual = DateTime.Now.Year;

int idade = anoAtual - anoNascUsuario;

if (anoNascUsuario >= 16)
{
    Console.WriteLine("Você pode votar!");
}
else
{
    Console.WriteLine("Você ainda não pode votar...");
}