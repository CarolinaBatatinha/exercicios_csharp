//Crie um jogo onde o computador vai sortear um número entre 1 e 5 o jogador vai tentar descobrir qual foi o valor sorteado.
Random aleatorio = new Random();
while (true)
{
    Console.WriteLine("Escolha um número entre 1 e 5:");
    int escolhaUsuario = Convert.ToInt32(Console.ReadLine());
    int escolhaComputador = aleatorio.Next(1, 5);

    if (escolhaUsuario < 1 || escolhaUsuario > 5)
    {
        Console.WriteLine("Comando inválido. Tente novamente.");
        continue;
    }
    if (escolhaUsuario == escolhaComputador)
    {
        Console.WriteLine("Acertou!");
        Console.WriteLine("Computador: {0}", escolhaComputador);
    }
    else
    {
        Console.WriteLine("Errou. Tente novamente");
        Console.WriteLine("Computador: {0}", escolhaComputador);
    }
}
