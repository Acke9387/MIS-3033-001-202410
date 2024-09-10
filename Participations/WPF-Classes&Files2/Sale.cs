using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Classes_Files2
{
    public class Sale
    {

        public DateTime TransactionDate { get; set; }
        public double Price { get; set; }
        public string PaymentType { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Sale()
        {
            TransactionDate = DateTime.Now;
            Price = 0.0;
            PaymentType = string.Empty;
            Name = string.Empty;
            Country = string.Empty;
        }

        public Sale(double price, string pType) : this()
        {
            //TransactionDate = DateTime.Now;
            Price = price;
            PaymentType = pType;
            //Name = string.Empty;
            //Country = string.Empty;
        }

        public override string ToString()
        {
            return $"[{PaymentType[0]}] {Name} - {Price.ToString("C")}";
        }
    }
}
