// 30) [DESAFIO] Refaça o algoritmo 25, acrescentando o recurso de mostrar que tipo de triângulo será formado:
// - EQUILÁTERO: todos os lados iguais
// - ISÓSCELES: dois lados iguais
// - ESCALENO: todos os lados diferentes

Console.WriteLine("Qual o comprimento do 1º segmento da reta em metros?");
double primeiroSegmento = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual o comprimento do 2º segmento da reta em metros?");
double segundoSegmento = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual o comprimento do 3º segmento da reta em metros?");
double terceiroSegmento = Convert.ToDouble(Console.ReadLine());

if (primeiroSegmento < segundoSegmento + terceiroSegmento && segundoSegmento < primeiroSegmento + terceiroSegmento && terceiroSegmento < segundoSegmento + primeiroSegmento)
{
    Console.WriteLine("É possível formar um triangulo.");
    if (primeiroSegmento == segundoSegmento && primeiroSegmento == terceiroSegmento)
    {
        Console.WriteLine("O triângulo é EQUILÁTERO!");
    }
    else if (primeiroSegmento != segundoSegmento && primeiroSegmento != terceiroSegmento && segundoSegmento != terceiroSegmento)
    {
        Console.WriteLine("O triângulo é ESCALENO!");
    }
    else
    {
        Console.WriteLine("O triângulo é ISÓSCELES!");
    }
}
else
{
    Console.WriteLine("Não é possível formar um triangulo.");
}