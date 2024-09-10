using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Example
{
    public class Sale
    {
        public int customer_id { get;set; }

        public DateTime purchase_date { get; set; }

        public double total_amount { get; set; }

        public Sale()
        {
            customer_id = 0;
            purchase_date = DateTime.Now;
            total_amount = 0.0;
        }

        public override string ToString()
        {
            return $"Customer ID: {customer_id}, Purchase Date: {purchase_date}, Total Amount: {total_amount}";
        }

    }
}
