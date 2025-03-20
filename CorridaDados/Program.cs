
namespace CorridaDados;

internal class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaChegada = 30;

        while (true)
        {
            int posicaoJogador1 = 0;
            bool jogoEmAndamento = true;

            while (jogoEmAndamento)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Jogo dos Dados");
                Console.WriteLine("------------------------------------");

                Console.Write("Pressione ENTER para lançar o dado...");
                Console.ReadLine();

                Random geradorDeNumeros = new Random();

                int resultado = geradorDeNumeros.Next(1, 7);

                Console.WriteLine("------------------------------------");
                Console.WriteLine($"O dado caiu no número: {resultado}");
                Console.WriteLine("------------------------------------");

                posicaoJogador1 += resultado;

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
                    posicaoJogador1 = limiteLinhaChegada;
                    jogoEmAndamento = false;

                    Console.WriteLine("Parabéns! Você alcançou a linha de chegada!");            
                }

                Console.ReadKey();
            }

            Console.Write("Deseja continuar? (s/n): ");
            string opcaoContinuar = Console.ReadLine().ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }
}
