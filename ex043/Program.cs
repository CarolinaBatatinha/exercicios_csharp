// 43) Desenvolva um algoritmo que mostre uma contagem regressiva de 30 até 1, marcando os números que forem divisíveis por 4, exatamente como mostrado abaixo:
// 30 29 [28] 27 26 25 [24] 23 22 21 [20] 19 18 17 [16]...
int i;
for (i = 30; i <= 30 && i > 0; i--)
{
    if (i % 4 == 0)
    {
        Console.Write("[{0}] ", i);
    }
    Console.Write("{0} ", i);
}