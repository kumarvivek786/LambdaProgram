using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1
            List<Person> employee = new List<Person>()
            {
                new Person { SSN = 11, Name = "vivek", Age = 25, Address = "Patna" },
                new Person { SSN = 12, Name = "Amit", Age = 28, Address = "Mumbai" },
                new Person { SSN = 13, Name = "Seema", Age = 28, Address = "satara" },
                new Person { SSN = 14, Name = "Ram", Age = 20, Address = "pune" },
                new Person { SSN = 15, Name = "Swati", Age = 61, Address = "satara" },
                new Person { SSN = 15, Name = "vikas", Age = 15, Address = "delhi" },

            };
           
        }
    }
}
