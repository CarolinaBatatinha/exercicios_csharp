// 29) Desenvolva um programa que leia o nome de um funcionário, seu salário, quantos anos ele trabalha na empresa e mostre seu novo salário, reajustado de acordo com a tabela a seguir:
// - Até 3 anos de empresa: aumento de 3%
// - entre 3 e 10 anos: aumento de 12.5%
// - 10 anos ou mais: aumento de 20%

Console.WriteLine("Qual o nome do funcionário? ");
string nome = Console.ReadLine();
Console.WriteLine("Qual o seu salário? ");
double salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Há quantos anos você trabalha na empresa? ");
double tempoServico = Convert.ToDouble(Console.ReadLine());

if (tempoServico > 0 && tempoServico <= 3)
{
    double salAumentadoJr = salario + (salario * 0.03);
    Console.WriteLine("Oi, {0}. Trabalhando há {1} anos com a empresa, você receberá um aumento de 3% e agora seu salário valerá R${2}.", nome, tempoServico, salAumentadoJr);
}
else if (tempoServico > 3 && tempoServico < 10)
{
    double salAumentadoPl = salario + (salario * 0.125);
    Console.WriteLine("Oi, {0}. Trabalhando há {1} anos com a empresa, você receberá um aumento de 12.5% e agora seu salário valerá R${2}.", nome, tempoServico, salAumentadoPl);
}
else if (tempoServico >= 10)
{
    double salAumentadoSr = salario+ (salario * 0.2);
    Console.WriteLine("Oi, {0}. Trabalhando há {1} anos com a empresa, você receberá um aumento de 20% e agora seu salário valerá R${2}.", nome, tempoServico, salAumentadoSr);
}
else {
    Console.WriteLine("Não se aplica");
}