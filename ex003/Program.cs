// 3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no final uma mensagem.
// Ex:
// Nome do Funcionário: Maria do Carmo
// Salário: 1850,45
// O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho.

Console.WriteLine("Qual o nome do funcionário?: ");
string nome = Console.ReadLine();
Console.WriteLine("Qual é o seu salário?: ");
float salario = float.Parse(Console.ReadLine());
Console.WriteLine("{0} recebe R${1}.", nome, salario);