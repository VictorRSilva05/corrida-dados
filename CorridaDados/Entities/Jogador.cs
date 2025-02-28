using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDados.Entities
{
    class Jogador
    {
        public string Nome { get; set; }
        public int Posicao { get; set; }
        public bool Ganhador { get; set;}

        public Jogador(string nome)
        {
            Nome = nome;
            Posicao = 0;
            Ganhador = false;
        }

        public int RolaDado()
        {
            Random random = new Random();
            int dado = random.Next(1, 7);
            return dado;
        }

        public void Vitoria()
        {
            if (Posicao > 29)
                Ganhador = true;
            else
                Ganhador = false;
        }
    }
}
