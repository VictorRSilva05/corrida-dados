
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

                if (posicaoJogador1 >= limiteLinhaChegada)
                {
                    posicaoJogador1 = limiteLinhaChegada;
                    jogoEmAndamento = false;

                    Console.WriteLine("Parabéns! Você alcançou a linha de chegada!");            
                }
                else
                {
                    Console.WriteLine($"Você está na posição: {posicaoJogador1} de {limiteLinhaChegada}!");
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
