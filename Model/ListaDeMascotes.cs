using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Busca_de_Pokemons.Model;

namespace Busca_de_Pokemons
{    public class ListaDeMascotes
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public List<Mascote> Results { get; set; }
    }
}
