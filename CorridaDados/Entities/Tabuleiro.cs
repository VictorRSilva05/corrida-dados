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
    }
}
