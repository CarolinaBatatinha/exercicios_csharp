// 45) O programa acima vai ter um problema quando digitarmos o primeiro valor maior que o último. Resolva esse problema com um código que funcione em qualquer situação.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor inicial da contagem: ");
        int valorInicial = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor final da contagem: ");
        int valorFinal = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o incremento da contagem: ");
        int incremento = int.Parse(Console.ReadLine());

        Console.WriteLine("Contagem:");

        if (valorInicial > valorFinal && incremento > 0)
        {
            incremento *= -1;
        }

        for (int i = valorInicial; i <= valorFinal; i += incremento)
        {
            Console.Write(i + " ");
        }

        Console.ReadKey();
    }
}
