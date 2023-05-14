// 25) [DESAFIO] Crie um programa que leia o tamanho de três segmentos de reta. Analise seus comprimentos e diga se é possível formar um triângulo com essas retas. Matematicamente, para três segmentos formarem um triângulo, o comprimento de cada lado deve ser menor que a soma dos outros dois.

Console.WriteLine("Qual o comprimento do  1º segmento da reta em metros?");
double primeiroSegmento = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual o comprimento do 2º segmento da reta em metros?");
double segundoSegmento = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual o comprimento do 3º segmento da reta em metros?");
double terceiroSegmento = Convert.ToDouble(Console.ReadLine());

if (primeiroSegmento < segundoSegmento + terceiroSegmento && segundoSegmento < primeiroSegmento + terceiroSegmento && terceiroSegmento < segundoSegmento + primeiroSegmento) {
    Console.WriteLine("É possível formar um triangulo.");
}
else {
    Console.WriteLine("Não é possível formar um triangulo.");
}