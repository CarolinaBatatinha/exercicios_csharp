﻿// 42) Faça um algoritmo que pergunte ao usuário um número inteiro e positivo qualquer e mostre uma contagem até esse valor:
// Ex: Digite um valor: 35
// Contagem: 1 2 3 4 5 6 7 ... 33 34 35 Acabou!

Console.WriteLine("Digite um número inteiro e positivo: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write($"{i} ");
}
Console.Write("Acabou!");
