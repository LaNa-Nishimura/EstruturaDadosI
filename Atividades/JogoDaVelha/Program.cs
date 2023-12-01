using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Definição de qual jogador iniciará a partida
        Random rnd = new Random();
        string jogador = "";
        int aux = rnd.Next(0, 2);
        if (aux == 0)
        {
            jogador = "O";
        }
        else
        {
            jogador = "X";
        }

        // Inicialização da variável de controle do Loop e da matriz multidimensional do jogo
        bool continuar = true;
        string[,] jogoDaVelha = { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };

        int jogadas = 0; // Contador de jogadas

        while (continuar == true)
        {
            // representação do jogo da velha
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"| {jogoDaVelha[i, j]} |");
                }
            }
            Console.WriteLine();

            // Alternância de jogadores
            if (jogador.Equals("O"))
            {
                jogador = "X";
            }
            else
            {
                jogador = "O";
            }

            while (true)
            {
                // Preenchimento da grade do jogo
                Console.WriteLine($"Jogador {jogador}, indique a linha em que deseja jogar.");
                int linha = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Agora, informe a coluna desejada.");
                int coluna = Convert.ToInt32(Console.ReadLine()) - 1;

                // Verificação da disponibilidade da área desejada
                if (jogoDaVelha[linha, coluna].Equals(" "))
                {
                    jogoDaVelha[linha, coluna] = jogador;
                    break;
                }
                else
                {
                    Console.WriteLine("Esta posição já está ocupada. Por favor, tente novamente.");
                }
            }

            jogadas++; // Incrementa o contador de jogadas

            // Verifica se houve um vencedor ou empate
            if (VerificarVencedor(jogoDaVelha, jogador) || jogadas == 9)
            {
                continuar = false;
            }
        }

        // Anuncia o resultado
        if (jogadas == 9)
        {
            Console.WriteLine("O jogo empatou!");
        }
        else
        {
            Console.WriteLine($"O jogador {jogador} ganhou!");
        }
    }

    // Função para verificar se houve um vencedor
    private static bool VerificarVencedor(string[,] jogoDaVelha, string jogador)
    {
        return false;
    }
}