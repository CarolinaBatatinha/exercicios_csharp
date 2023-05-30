// 4) Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório
// entre eles.
// Ex:
// Digite um valor: 8
// Digite outro valor: 5
// A soma entre 8 e 5 é igual a 13.

Console.WriteLine("Digite um valor: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro valor: ");
int numB = int.Parse(Console.ReadLine());

int soma = numA + numB;

Console.WriteLine("A soma entre {0} e {1} é igual a {2}.", numA, numB, soma);
