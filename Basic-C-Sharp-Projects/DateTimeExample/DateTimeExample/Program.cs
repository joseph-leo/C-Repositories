using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine("It is " + date);
            Console.WriteLine("How many hours will your journey take?");
            double hours = Convert.ToDouble(Console.ReadLine());
            DateTime arrivalTime = new DateTime();
            arrivalTime = date.AddHours(hours);
            Console.WriteLine("If you leave now you will arrive at " + arrivalTime);
            Console.Read();
        }
    }
}
