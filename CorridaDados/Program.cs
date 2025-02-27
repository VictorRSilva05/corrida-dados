using CorridaDados.Entities;

namespace CorridaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro();

            Console.WriteLine("##### C O R R I D A #####");
            Console.Write("\nInsira seu nome: ");
            string nome = Console.ReadLine();

            while(String.IsNullOrEmpty(nome))
            {
                Console.Write("Por favor insira seu nome: ");
                nome = Console.ReadLine();
            }

            Jogador jogador1 = new Jogador(nome);
            Jogador jogador2 = new Jogador(System.Environment.MachineName);

            Console.Clear();
            Console.WriteLine($"{jogador1.Nome} VS {jogador2.Nome.ToLower()}");

            tabuleiro.ImprimirTabuleiro();
            tabuleiro.ImprimirTabuleiro();
        }
    }
}
