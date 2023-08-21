// Desenvolva um programa que leia uma distância em metros e mostre os valores relativos em outras medidas.
// Ex:
// Digite uma distância em metros: 185.72
// A distância de 85.7m corresponde a:
// 0.18572Km  // 1.8572Hm  // 18.572Dam  // 1857.2dm  // 18572.0cm  // 185720.0mm

Console.WriteLine("Digite uma distância em metros: ");
double distMetro = double.Parse(Console.ReadLine());

double distKm = distMetro/1000;
double distHm = distMetro/100;
double distDam = distMetro/10;
double distCm = distMetro*100;

Console.WriteLine($"A distância de {distMetro} metros corresponde a:");
Console.WriteLine(distKm +" Km");
Console.WriteLine(distHm +" Hm");
Console.WriteLine(distDam +" Dam");
Console.WriteLine(distCm +" cm");
