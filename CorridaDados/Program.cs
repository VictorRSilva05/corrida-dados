
namespace CorridaDados;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
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

            Console.Write("Deseja continuar? (s/n): ");
            string opcaoContinuar = Console.ReadLine().ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }
}
