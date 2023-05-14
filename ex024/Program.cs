// 24) Faça um algoritmo que pergunte a distância que um passageiro deseja percorrer em Km. Calcule o preço da passagem, cobrando R$0.50 por Km para viagens até 200Km e R$0.45 para viagens mais longas.

Console.WriteLine("Qual a distância em km que você deseja percorrer?");
double distancia = Convert.ToDouble(Console.ReadLine());

if (distancia <= 200)
{
    double precoViagemCurta = distancia * .5;
    Console.WriteLine("Para a viagem de {0}km, o preço da passagem é de R${1}.", distancia, precoViagemCurta);
}
else
{
    double precoViagemLonga = distancia * .45;
    Console.WriteLine("Para a viagem de {0}km, o preço da passagem é de R${1}.", distancia, precoViagemLonga);
}