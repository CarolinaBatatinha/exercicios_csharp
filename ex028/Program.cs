using System.ComponentModel.DataAnnotations;
// 28) Faça um programa que leia a largura e o comprimento de um terreno retangular, calculando e mostrando a sua área em m². O programa também devemostrar a classificação desse terreno, de acordo com a lista abaixo:
// - Abaixo de 100m² = TERRENO POPULAR
// - Entre 100m² e 500m² = TERRENO MASTER
// - Acima de 500m² = TERRENO VIP

Console.WriteLine("Digite a largura do terreno em metros: ");
double largura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a altura do terreno  em metros: ");
double comprimento = Convert.ToDouble(Console.ReadLine());

double area = comprimento * largura;

if (area < 100)
{
    Console.WriteLine("Terreno popular");
}
else if (area >= 100 && area <= 500)
{
    Console.WriteLine("Terreno master");
}
else
{
    Console.WriteLine("Terreno VIP");
}
