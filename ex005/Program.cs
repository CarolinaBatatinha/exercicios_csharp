// 5) Faça um programa que leia as duas notas de um aluno em uma matéria e mostre
// na tela a sua média na disciplina.
// Ex:
// Nota 1: 4.5
// Nota 2: 8.5
// A média entre 4.5 e 8.5 é igual a 6.5

Console.WriteLine("Digite sua primeira nota: ");
double n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite sua segunda nota: ");
double n2 = double.Parse(Console.ReadLine());

double media = (n1 + n2)/2;

Console.WriteLine("A média entre {0} e {1} é igual a {2}.", n1, n2, media);
Console.ReadLine();