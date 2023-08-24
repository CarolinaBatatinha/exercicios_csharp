// //36) Um programa de vida saudável quer dar pontos atividades físicas que podem ser trocados por dinheiro. O sistema funciona assim:
// - Cada hora de atividade física no mês vale pontos
// - até 10h de atividade no mês: ganha 2 pontos por hora
// - de 10h até 20h de atividade no mês: ganha 5 pontos por hora
// - acima de 20h de atividade no mês: ganha 10 pontos por hora
// - A cada ponto ganho, o cliente fatura R$0,05 (5 centavos)
// Faça um programa que leia quantas horas de atividade uma pessoa teve por mês,
// calcule e mostre quantos pontos ela teve e quanto dinheiro ela conseguiu ganhar.

Console.WriteLine("Quantas horas de atividade você teve nesse mês?");
double horasAtividade = Convert.ToDouble(Console.ReadLine());
double premio = horasAtividade * 0.05;

while (true)

{
    if (horasAtividade <= 10)
    {
        double pontosPorHora = horasAtividade * 2;
        Console.WriteLine($"Você fez {horasAtividades} horas de atividade, conseguiu {pontosPorHora} pontos e vai ganhar R$ {premio:F2}.");
        break;
    }
    else if (horasAtividade > 10 && horasAtividade <= 20)
    {
        double pontosPorHora = horasAtividade * 5;
        Console.WriteLine($"Você fez {horasAtividades} horas de atividade, conseguiu {pontosPorHora} pontos e vai ganhar R$ {premio:F2}.");
        break;
    }
    else
    {
        double pontosPorHora = horasAtividade * 10;
        Console.WriteLine($"Você fez {horasAtividades} horas de atividade, conseguiu {pontosPorHora} pontos e vai ganhar R$ {premio:F2}.";
        break;
    }
}
