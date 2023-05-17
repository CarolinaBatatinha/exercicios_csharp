// 44) Crie um algoritmo que leia o valor inicial da contagem, o valor final e o incremento, mostrando em seguida todos os valores no intervalo:
// Ex: Digite o primeiro Valor: 3
// Digite o último Valor: 10
// Digite o incremento: 2
// Contagem: 3 5 7 9 Acabou!

Console.WriteLine("Digite o primeiro valor: ");
int primeiroValor = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o último valor: ");
int ultimoValor = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o incremento: ");
int incremento = int.Parse(Console.ReadLine());

Console.WriteLine("Contagem: ");

for (int i = primeiroValor; i <= ultimoValor; i += incremento)
{
    Console.Write("{0} ", i);
}
Console.WriteLine("Acabou!");