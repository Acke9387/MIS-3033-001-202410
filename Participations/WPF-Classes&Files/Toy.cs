using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Classes_Files
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string  Name { get; set; }

        public double Price { get; set; }

        public string Image { get; set; }

        private string Aisle { get; set; }

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Image = "";
            Aisle = "";
        }

        public string GetAisle()
        {
            return $"{Manufacturer.ToUpper()[0]}{Price.ToString().Replace("$", "").Replace(".", "").Replace(",","")}";
        }

        public override string ToString()
        {
            return $"{Manufacturer} {Name} {Price.ToString("C")}";
        }

    }
}
