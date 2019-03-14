using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: ");
            string oneRate = Console.ReadLine();
            Console.WriteLine("Hours worked per week: ");
            string oneHours = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: ");
            string twoRate = Console.ReadLine();
            Console.WriteLine("Hours worked per week: ");
            string twoHours = Console.ReadLine();
            Console.WriteLine("");

            double oneSalary = (Convert.ToDouble(oneRate) * Convert.ToDouble(oneHours)) * 52.0;
            double twoSalary = (Convert.ToDouble(twoRate) * Convert.ToDouble(twoHours) * 52.0);
            bool oneGreater = oneSalary > twoSalary;

            Console.WriteLine("Annual salary of Person 1: " + oneSalary.ToString());
            Console.WriteLine("");
            Console.WriteLine("Annual salary of Person 2: " + twoSalary.ToString());
            Console.WriteLine("");
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(oneGreater);
            Console.Read();
        }
    }
}
