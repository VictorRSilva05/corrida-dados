
namespace CorridaDados;

internal class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaChegada = 30;

        while (true)
        {
            int posicaoJogador1 = 0;
            int posicaoJogador2 = 0;

            bool jogoEmAndamento = true;

            while (jogoEmAndamento)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Jogo dos Dados");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Rodada do jogador");
                Console.WriteLine("------------------------------------");
                Console.Write("Pressione ENTER para lançar o dado...");
                Console.ReadLine();

                int resultadoJogador = SortearDado();

                Console.WriteLine("------------------------------------");
                Console.WriteLine($"O dado caiu no número: {resultadoJogador}");
                Console.WriteLine("------------------------------------");

                posicaoJogador1 += resultadoJogador;

                Console.WriteLine($"Você está na posição: {posicaoJogador1} de {limiteLinhaChegada}!");

                if(posicaoJogador1 == 5 || posicaoJogador1 == 10 || posicaoJogador1 == 15 || posicaoJogador1 == 25)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

                    posicaoJogador1 += 3;

                    Console.WriteLine($"Você avançou para a posição: {posicaoJogador1}");
                    Console.WriteLine("------------------------------------");
                }
                else if (posicaoJogador1 == 7 || posicaoJogador1 == 13 || posicaoJogador1 == 20)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                    posicaoJogador1 -= 2;

                    Console.WriteLine($"Você recuou para a posição: {posicaoJogador1}");
                    Console.WriteLine("------------------------------------");
                }

                if (posicaoJogador1 >= limiteLinhaChegada)
                {
                    Console.WriteLine("Parabéns! Você alcançou a linha de chegada!");
                    jogoEmAndamento = false;
                    continue;
                }

                Console.WriteLine("Rodada do computador");
                Console.WriteLine("------------------------------------");
                Console.Write("Pressione ENTER para visualizar a rodada do computador");

                Console.ReadKey();

                int resultadoComputador = SortearDado();

                Console.WriteLine("\n------------------------------------");
                Console.WriteLine($"O dado caiu no número: {resultadoJogador}");
                Console.WriteLine("------------------------------------");

                posicaoJogador2 += resultadoComputador;

                Console.WriteLine($"O computador está na posição: {posicaoJogador2} de {limiteLinhaChegada}!");

                if (posicaoJogador2 == 5 || posicaoJogador2 == 10 || posicaoJogador2 == 15 || posicaoJogador2 == 25)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

                    posicaoJogador2 += 3;

                    Console.WriteLine($"O computador avançou para a posição: {posicaoJogador2}");
                    Console.WriteLine("------------------------------------");
                }
                else if (posicaoJogador2 == 7 || posicaoJogador2 == 13 || posicaoJogador2 == 20)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                    posicaoJogador2 -= 2;

                    Console.WriteLine($"O computador recuou para a posição: {posicaoJogador2}");
                    Console.WriteLine("------------------------------------");
                }

                if (posicaoJogador2 >= limiteLinhaChegada)
                {
                    Console.WriteLine("Que pena! O computador alcançou a linha de chegada, tente novamente!");
                    jogoEmAndamento = false;
                    continue;
                }

                Console.ReadKey();
            }

            Console.Write("Deseja continuar? (s/n): ");
            string opcaoContinuar = Console.ReadLine().ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }

    static int SortearDado()
    {
        Random geradorDeNumeros = new Random();

        int resultado = geradorDeNumeros.Next(1, 7);
        return resultado;
    }
}
