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
                new Person { SSN = 16, Name = "vikas", Age = 15, Address = "delhi" },

            };
            //uc2
            var result = employee.FindAll(x => x.Age < 60).Take(2);
            foreach (Person emp in result)
            {
                Console.WriteLine("Name :" + emp.Name);
                Console.WriteLine("Age :" + emp.Age);
                Console.WriteLine("Address :" + emp.Address);
            }
            //uc3
            var Result = employee.FindAll(x => (x.Age >= 13 && x.Age <= 18));
            foreach (Person emp1 in Result)
            {
                Console.WriteLine("Name :" + emp1.Name);
                Console.WriteLine("Age :" + emp1.Age);
                Console.WriteLine("Address :" + emp1.Address);
            }
            //uc4
            var Result2 = employee.Average(e => e.Age);
            Console.WriteLine("The Avereage age :");
            Console.WriteLine("Avg Age" + Result2);
            
            
            //uc 5
            Console.WriteLine("Enter Name");
            string Name = Console.ReadLine();

            if (employee.Any(x => (x.Name == Name)))
            {
                Console.WriteLine("Present in list");
            }
            else
                Console.WriteLine("not present");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
