// 7) Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a
// sua terça parte.
// Ex:
// Digite um número: 3.5
// O dobro de 3.5 é 7.0
// A terça parte de 3.5 é 1.16666

Console.WriteLine("Digite um número real: ");
double numReal = double.Parse(Console.ReadLine());

double dobro = numReal * 2;
double terco = numReal / 3;

Console.WriteLine("O dobro de {0} é igual a {1}.", numReal, dobro);
Console.WriteLine("A terça parte de {0} é igual a {1}.", numReal, terco);
