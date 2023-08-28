using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busca_de_Pokemons.Model
{
    public class Mascote
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public int Fome{ get; set; }
        public int Felicidade { get; set; }
        public List<InfoHabilidades> Abilities { get; set; }

        public Mascote()
        {
            Fome = 0;
            Felicidade = 0;
        }
    }
}
