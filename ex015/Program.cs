// 15) Crie um programa que leia o número de dias trabalhados em um mês e mostre o salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25 por hora trabalhada.

Console.WriteLine("Por quantos dias você trabalhou?");
int diasTrabalhados = int.Parse(Console.ReadLine());
int horaTrabalhadaPorDia = 8;
double horaTraballhada = 25;

double valorPorDia = 8 * 25;
double salario = valorPorDia * diasTrabalhados;

Console.WriteLine("Você trabalhou por {0} dias e vai receber R${1:C}.", diasTrabalhados, salario);