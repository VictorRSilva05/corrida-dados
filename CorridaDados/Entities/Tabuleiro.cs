using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDados.Entities
{
    class Tabuleiro
    {
        public void ImprimirTabuleiro()
        {
            Console.Write("\n|");
            for (int i = 0; i < 30; i++)
            {
                
                Console.Write("-");
            }
            Console.Write("|");
        }

        public void Avancar(int valor, Jogador jogador)
        {
            switch (valor)
            {
                case 5:
                    jogador.Posicao += (valor + 3);
                    break;
                case 7:
                    jogador.Posicao += (valor - 2);
                    break;
                case 10:
                    jogador.Posicao += (valor + 3);
                    break;
                case 13:
                    jogador.Posicao += (valor - 2);
                    break;
                case 15:
                    jogador.Posicao += (valor + 3);
                    break;
                case 20:
                    jogador.Posicao += (valor - 2);
                    break;
                default:
                    jogador.Posicao += valor;
                    break;
            }
                
        }
    }
}
