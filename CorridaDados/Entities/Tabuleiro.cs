using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDados.Entities
{
    class Tabuleiro
    {
        public void ImprimirTabuleiro(int posicao)
        {
            Console.Write("\n|");
            for (int i = 0; i < 30; i++)
            {
                if (posicao != i)
                    Console.Write("-");
                else
                    Console.Write("@");
            }
            Console.Write("|");
        }

        public void Avancar(int valor, Jogador jogador)
        {
            switch (valor)
            {
                case 5:
                    jogador.Posicao += (valor + 3);
                    Console.WriteLine("Avançou mais 3 posições!");
                    break;
                case 7:
                    jogador.Posicao += (valor - 2);
                    Console.WriteLine("voltou 2 posições!");
                    break;
                case 10:
                    jogador.Posicao += (valor + 3);
                    Console.WriteLine("Avançou mais 3 posições!");
                    break;
                case 13:
                    jogador.Posicao += (valor - 2);
                    Console.WriteLine("voltou 2 posições!");
                    break;
                case 15:
                    jogador.Posicao += (valor + 3);
                    Console.WriteLine("Avançou mais 3 posições!");
                    break;
                case 20:
                    jogador.Posicao += (valor - 2);
                    Console.WriteLine("voltou 2 posições!");
                    break;
                default:
                    jogador.Posicao += valor;
                    break;
            }
                
        }
    }
}
