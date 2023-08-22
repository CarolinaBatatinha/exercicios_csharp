// 17) Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse 80Km/h, exiba uma mensagem dizendo que o usuário foi multado. Nesse caso, exiba o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida.

Console.WriteLine("Qual a velocidade do veículo?");
double velVeiculo = double.Parse(Console.ReadLine());

if (velVeiculo > 80)
{
    double valorMulta = (velVeiculo - 80) * 5;
    Console.WriteLine("Você ultrapassou a velocidade máxima permitida e foi MULTADO no valor de R${0:F2} .", valorMulta);
}
else
{
    Console.WriteLine("Oxe, relaxe. Você tá andando dentro da velocidade permitida. Vamo tomar um sorvete?");
}