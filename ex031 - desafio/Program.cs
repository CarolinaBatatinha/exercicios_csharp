using System.Xml.Serialization;
//31) [DESAFIO] Crie um jogo de JoKenPo (Pedra-Papel-Tesoura)

while (true)
{
    Random aleatorio = new Random();

    Console.WriteLine("Escolha um movimento:");
    Console.WriteLine("1 - Pedra | 2 - Papel | 3 - Tesoura");

    int movUsuario = Convert.ToInt32(Console.ReadLine());

    if (movUsuario < 1 || movUsuario > 3)
    {
        Console.WriteLine("Comando inválido. Tente novamente.");
        continue;
    }

    int movComputador = aleatorio.Next(1, 3); //olha aqui depois!!

    Console.WriteLine("O computador escolheu {0}", movComputador);

    if (movUsuario == movComputador)
    {
        Console.WriteLine("Empate");
    }
    else if (movUsuario == 1 && movComputador == 3)
    {
        Console.WriteLine("Você venceu");
    }
    else if (movUsuario == 2 && movComputador == 1)
    {
        Console.WriteLine("Você venceu");
    }
    else if (movUsuario == 3 && movComputador == 2)
    {
        Console.WriteLine("Você venceu");
    }
    else
    {
        Console.WriteLine("Você perdeu");
    }

    Console.WriteLine("Pressione qualquer tecla para continuar ou 'S' para sair");
    string encerraJogo = Console.ReadLine();
    if (encerraJogo.ToUpper() == "S")
    {
        break;
    }
    Console.Clear();
}
