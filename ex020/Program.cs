// 20) Desenvolva um programa que leia um número inteiro e mostre se ele é PAR ou ÍMPAR.

Console.WriteLine("Digite um número inteiro:");
int num = int.Parse(Console.ReadLine());

if(num % 2 == 0){
    Console.WriteLine($"{num} é par");
} else {
    Console.WriteLine($"{num} é ímpar");
}