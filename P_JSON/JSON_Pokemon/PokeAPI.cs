using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon
{
    public class PokeAPI
    {
        public List<Pokemon> results { get; set; }

        public PokeAPI()
        {
            results = new List<Pokemon>();
        }
    }
}
