// 37) Uma empresa precisa reajustar o salário dos seus funcionários, dando um aumento de acordo com alguns fatores. Faça um programa que leia o salário atual,  o gênero do funcionário e há quantos anos esse funcionário trabalha na empresa. No final, mostre o seu novo salário, baseado na tabela a seguir:
//             Mulheres
// - menos de 15 anos de empresa: +5%
// - de 15 até 20 anos de empresa: +12%
// - mais de 20 anos de empresa: +23%
//               Homens
// - menos de 20 anos de empresa: +3%
// - de 20 até 30 anos de empresa: +13%
// - mais de 30 anos de empresa: +25%

Console.WriteLine("Qual o seu gênero?");
string gen = Console.ReadLine();
Console.WriteLine("Qual o seu salário atual?");
double sal = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Há quanto tempo você trabalha na empresa?");
double tempoServico = Convert.ToDouble(Console.ReadLine());

while (true)
{
    if (gen == "feminino")
    {
        if (tempoServico < 15)
        {
            double salReajustado = sal * 1.05;
            Console.WriteLine("Seu novo salário é de R$ {0:N2}", salReajustado);
            break;
        }
        else if (tempoServico >= 15 && tempoServico < 20)
        {
            double salReajustado = sal * 1.12;
            Console.WriteLine("Seu novo salário é de R$ {0:N2}", salReajustado);
            break;
        }
        else
        {
            double salReajustado = sal * 1.23;
            Console.WriteLine("Seu novo salário é de R$ {0:N2}", salReajustado);
            break;
        }
    }
    else if (gen == "masculino")
    {
if (tempoServico < 15)
        {
            double salReajustado = sal * 1.03;
            Console.WriteLine("Seu novo salário é de R$ {0:N2}", salReajustado);
            break;
        }
        else if (tempoServico >= 15 && tempoServico < 20)
        {
            double salReajustado = sal * 1.13;
            Console.WriteLine("Seu novo salário é de R$ {0:N2}", salReajustado);
            break;
        }
        else
        {
            double salReajustado = sal * 1.25;
            Console.WriteLine("Seu novo salário é de R$ {0:N2}", salReajustado);
            break;
        }
    }
    else
    {
        Console.WriteLine("Gênero incorreto. Tente novamente.");
    }
}
