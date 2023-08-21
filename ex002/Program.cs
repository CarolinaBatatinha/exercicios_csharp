//2) Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boas vindas para ela:
// Ex:
// Qual é o seu nome? João da Silva
// Olá João da Silva, é um prazer te conhecer!

Console.WriteLine("Qual é o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Oi, {0}, é um prazer te conhecer!",nome);
