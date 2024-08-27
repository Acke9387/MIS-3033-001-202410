using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPFApplication
{
    public class Student
    {
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public Student()
        {
            FirstName = "";
            LastName = "";
            Address = "";
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
