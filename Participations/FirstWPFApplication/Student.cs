using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing.IndexedProperties;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPFApplication
{
    public class Student
    {

        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }

        public Student()
        {
            Name = string.Empty;
            Birthdate = null;
        }

        public int CalculateAge()
        {
            int age = 0;

            TimeSpan timeSpan = DateTime.Now - Birthdate.Value;

            //return timeSpan.Days / 365;

            // Calculate the age of the student
            if (Birthdate.HasValue)
            {
                DateTime today = DateTime.Today;
                age = today.Year - Birthdate.Value.Year;
                if (Birthdate.Value > today.AddYears(-age))
                {
                    age--;
                }
            }

            return age;
        }

        public override string ToString()
        {
            return Name + " - " + Birthdate.Value.ToShortDateString();
        }

    }
}
