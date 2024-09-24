using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_From_A_File_2
{
    public class Market
    {
        public List<Fruit> fruits { get; set; }

        public Market()
        {
            fruits = new List<Fruit>();
        }
    }
}
