//13) Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o seu novo salário, com 15% de aumento.

Console.WriteLine("Quanto você recebe de salário?: ");
double salarioAtual  = double.Parse(Console.ReadLine());

double salarioAumentado = salarioAtual + (salarioAtual * 0.15);

Console.WriteLine("Você está recebendo R${0} atualmente. Com o aumento, você passará a receber R${1}.", salarioAtual, salarioAumentado);