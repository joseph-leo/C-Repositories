using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                FirstName = "Joe",
                LastName = "Leonard",
                Id = 1
            };

            Employee employee2 = new Employee()
            {
                FirstName = "Bob",
                LastName = "Sanders",
                Id = 1
            };

            employee1.SayName();
            employee2.SayName();

            Console.WriteLine("Do these employees share an ID #?");
            Console.WriteLine(employee1 == employee2);

            Console.Read();
        }
    }
}
