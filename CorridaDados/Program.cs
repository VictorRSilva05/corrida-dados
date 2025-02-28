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
            Console.WriteLine($"{jogador1.Nome} VS {jogador2.Nome}");

            int turno = default;
            int valor = default;

            Console.WriteLine("\n");

            while (jogador2.Ganhador == false || jogador1.Ganhador == false)
            {
                turno++;

                if(turno % 2 == 0)
                {
                    valor = jogador1.RolaDado();
                    Console.WriteLine($"\n{jogador1.Nome} tirou {valor}");
                    tabuleiro.Avancar(valor, jogador1);
                    Console.WriteLine(jogador1.Posicao);
                    jogador1.Vitoria();
                    tabuleiro.ImprimirTabuleiro(jogador1.Posicao);
                    Console.WriteLine("\nAperte para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    valor = jogador2.RolaDado();
                    Console.WriteLine($"\n{jogador2.Nome} tirou {valor}");
                    tabuleiro.Avancar(valor, jogador2);
                    Console.WriteLine(jogador2.Posicao);
                    jogador2.Vitoria();
                    tabuleiro.ImprimirTabuleiro(jogador2.Posicao);
                }
               
                if(jogador1.Ganhador == true)
                {
                    Console.Clear();
                    Console.WriteLine($"{jogador1.Nome} é o vencedor!!!!");
                    goto Fim;
                }
                else if(jogador2.Ganhador == true)
                {
                    Console.Clear();
                    Console.WriteLine($"{jogador2.Nome} é o vencedor!!!!");
                    goto Fim;
                }
            }
        Fim:
            Console.WriteLine("Aperte qualquer tecla para sair");
        }
    }
}
