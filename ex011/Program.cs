// 11) Desenvolva uma lógica que leia os valores de A, B e C de uma equação do segundo grau e mostre o valor de Delta.

using System;

namespace ex011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Digite o valor de A");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine ("Digite o valor de B");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine ("Digite o valor de C");
            double C = double.Parse(Console.ReadLine());

            double delta = Math.Pow(B,2) - (4 * A * C);

            Console.WriteLine($"O valor de delta é {delta}.");
        }
    }
}