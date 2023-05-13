// 14) A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva um programa que pergunte a quantidade de Km percorridos por um carro alugado e a quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar, sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado.

Console.WriteLine("Por quandos dias você alugou o carro?");
int numDias = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a quilometragem rodada?");
double kmRodado = double.Parse(Console.ReadLine());

double valorDia = 90;
double valorKmRodado = 0.2;

double total = (valorDia * numDias) + (valorKmRodado * kmRodado);

Console.WriteLine("Você usou o carro por {0} dias e rodou {1} Km. \nO total a pagar é de R${2}.", numDias, kmRodado, total);