// 26) Escreva um algoritmo que leia dois números inteiros e compare-os, mostrando na tela uma das mensagens abaixo:
// - O primeiro valor é o maior
// - O segundo valor é o maior
// - Não existe valor maior, os dois são iguais

Console.WriteLine("Digite um número inteiro:");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um outro número inteiro:");
int numB = int.Parse(Console.ReadLine());

if (numA > numB){
    Console.WriteLine("O primeiro valor é o maior");
} else if (numA < numB){
    Console.WriteLine("O segundo valor é o maior");
} else {
    Console.WriteLine("Não existe valor maior, os dois são iguais");
}
