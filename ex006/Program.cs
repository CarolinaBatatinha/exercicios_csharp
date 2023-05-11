// 6) Faça um programa que leia um número inteiro e mostre o seu antecessor e seu
// sucessor.
// Ex:
// Digite um número: 9
// O antecessor de 9 é 8
// O sucessor de 9 é 10

Console.WriteLine("Digite um número inteiro: ");
int numDigitado = int.Parse(Console.ReadLine());
int sucessor = numDigitado + 1;
int antecessor = numDigitado - 1;
Console.WriteLine("O antecessor é {0}.", antecessor);
Console.WriteLine("O sucessor é {0}.", sucessor);