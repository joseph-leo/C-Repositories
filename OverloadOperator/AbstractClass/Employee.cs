using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.Write("has quit.");
        }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            bool result = employee1.Id == employee2.Id;
            return result;
        }

        public static bool operator!= (Employee employee1, Employee employee2)
        {
            bool result = employee1.Id != employee2.Id;
            return result;
        }
    }
}
