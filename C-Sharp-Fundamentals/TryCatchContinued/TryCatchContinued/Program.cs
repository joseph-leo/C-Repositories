using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchContinued
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAge;

            do
            {
                try
                {
                    DateTime currentDate = DateTime.Now;
                    int currentYear = currentDate.Year;
                    Console.WriteLine("How old are you?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age < 0)
                    {
                        throw new NegativeAgeException();
                    }
                    else if (age == 0)
                    {
                        throw new AgeOfZeroException();
                    }
                    int birthYear = currentYear - age;
                    Console.WriteLine("You were born in " + birthYear);
                    validAge = true;
                }
                catch (NegativeAgeException)
                {
                    Console.WriteLine("One cannot be negative years old. Please enter a positive integer.");
                    validAge = false;
                }
                catch (AgeOfZeroException)
                {
                    Console.WriteLine("You cannot be 0 years old. Please enter a positive integer.");
                    validAge = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    validAge = false;
                }
            }
            while (!validAge);

            Console.Read();
        }
    }
}
