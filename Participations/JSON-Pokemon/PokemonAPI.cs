using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon
{
    public class PokemonAPI
    {

        public List<Result> Results { get; set; }

    }

    public class Result
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
