using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon
{
    public class Pokemon
    {

        public string Name { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public Sprite Sprites { get; set; }

    }

    public class Sprite
    {
        public string Front_Default { get; set; }
        public string Back_Default { get; set; }

    }
}
