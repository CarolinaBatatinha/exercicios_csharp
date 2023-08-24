// 34) O Índice de Massa Corpórea (IMC) é um valor calculado baseado na altura e no peso de uma pessoa. De acordo com o valor do IMC, podemos classificar o indivíduo dentro de certas faixas.
// - abaixo de 18.5: Abaixo do peso
// - entre 18.5 e 25: Peso ideal
// - entre 25 e 30: Sobrepeso
// - entre 30 e 40: Obesidade
// - acima de 40: Obseidade mórbida

Console.WriteLine("Qual o seu peso?");
double peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual a sua altura?");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc < 18.5)
{
    Console.WriteLine($"Abaixo do peso, IMC: {imc:F1}");
}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine($"Peso ideal, IMC: {imc:F1}");
}
else if (imc >= 25 && imc < 30)
{
    Console.WriteLine($"Sobrepeso, IMC: {imc:F1}");
}
else if (imc >= 30 && imc < 40)
{
    Console.WriteLine($"Obesidade, IMC: {imc:F1}");
} else {
    Console.WriteLine($"Obesidade mórbida, IMC: {imc:F1}");
}
