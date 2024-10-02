using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_Review
{
    
    public class Restaurant
    {

        public int Rank { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Sales { get; set; }

        /// <summary>
        /// Default/Empty constructor
        /// </summary>
        public Restaurant()
        {
            Rank = 0;
            Logo = string.Empty;
            Name = string.Empty;
            Category = string.Empty;
            Sales = 0.0;
        }
        /// <summary>
        /// Overloaded contructor taking 5 parameters
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="logo"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="sales"></param>
        public Restaurant(int rank, string logo, string name, string category, double sales)
        {
            Rank = rank;
            Logo = logo;
            Name = name;
            Category = category;
            Sales = sales;
        }

        /// <summary>
        /// Overloaded constructor taking an array of strings
        /// </summary>
        /// <param name="values"></param>
        public Restaurant(string[] values)
        {
            //  0   1       2       3       4
            //RANK;LOGO;COMPANY;CATEGORY;2018 US SYSTEMWIDE SALES MILLIONS
            //Rank = int.Parse(values[0]);
            bool rankIsNumber;
            int rank;
            if (int.TryParse(values[0], out rank))
            {
                Rank = rank;
            }
            else
            {
                Rank = -1;
            }

            Logo = values[1];
            Name = values[2];
            Category = values[3];
            Sales = double.Parse(values[4]);
        }

        public override string ToString()
        {
            return $"{Rank} ({Category}) - {Name} : {Sales.ToString("C")}";
        }

    }
}
