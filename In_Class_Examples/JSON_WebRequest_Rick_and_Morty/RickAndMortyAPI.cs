using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_WebRequest_Rick_and_Morty
{
    public class RickAndMortyAPI
    {
        public Info Info { get; set; }

        public List<Result> Results { get; set; }

    }

    public class Result
    {
        public int id { get; set; }
        public string name { get; set; }
        
        public string image { get; set; }

        public override string ToString()
        {
            return name;
        }

    }

    public class Info
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
    }
}
