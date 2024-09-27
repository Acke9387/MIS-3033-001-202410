using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Game_of_Thrones_Quote
{
    public class GOTQuoteAPI
    {
        public string sentence { get; set; }

        public Character character { get; set; }

    }

    public class Character
    {
        public string name { get; set; }
        public string slug { get; set; }

    }
}
