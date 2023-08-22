using System.Transactions;
// 16) [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um fumante. Pergunte a quantidade de cigarros fumados por dias e quantos anos ele já fumou. Considere que um fumante perde 10 min de vida a cada cigarro. Calcule quantos dias de vida um fumante perderá e exiba o total em dias.

Console.WriteLine("Quantos cigarros você fuma por dia?");
int cigarrosPorDia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Há quantos anos você fuma?");
double anosFumando = double.Parse(Console.ReadLine());

double tempoPerdido = cigarrosPorDia * anosFumando * 365 ;
double minutosPerdidos = tempoPerdido * 10;
double anosPerdidos = Math.Round(minutosPerdidos / (60 * 24));

Console.WriteLine("Você fumou {0} cigarros por dia ao longo de {1} anos. Você perdeu aproximadamente {2} dias da sua vida. Tome tento!",cigarrosPorDia, anosFumando, anosPerdidos);