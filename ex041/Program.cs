// 41) Desenvolva um programa que mostre na tela a seguinte contagem: 100 95 90 85 80 ... 0 Acabou!

for (int i = 100; i <= 100 && i >= 0; i -= 5)
{
    Console.Write("{0} ", i);
}
Console.Write("Acabou!");