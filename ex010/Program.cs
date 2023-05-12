// 10) Faça um algoritmo que leia a largura e altura de uma parede, calcule e mostre a área a ser pintada e a quantidade de tinta necessária para o serviço, sabendo que cada litro de tinta pinta uma área de 2 metros quadrados.
Console.WriteLine("Qual a largura dessa parede?");
double largura = double.Parse(Console.ReadLine());
Console.WriteLine("E qual a altura dessa parede?");
double altura = double.Parse(Console.ReadLine());

double area = largura * altura;
double quantidadeTinta = area/2;

Console.WriteLine("A área a ser pintada é de {0}m² e, para tanto, vai gastar {1} litros de tinta.", area, quantidadeTinta);