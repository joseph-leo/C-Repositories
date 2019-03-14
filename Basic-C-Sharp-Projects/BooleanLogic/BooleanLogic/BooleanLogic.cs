using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class BooleanLogic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine("Have you ever had a DUI? Yes/No:");
            string duiInput = Console.ReadLine();
            bool dui = false;

            if (duiInput.ToLower() == "yes")
            {
                dui = true;
            }
            else if (duiInput.ToLower() == "no")
            {
                dui = false;
            }
            while (duiInput != "yes" && duiInput != "no")
            {
                Console.WriteLine("Please enter 'yes' or 'no':");
                duiInput = Console.ReadLine();
                if (duiInput.ToLower() == "yes")
                {
                    dui = true;
                }
                else if (duiInput.ToLower() == "no")
                {
                    dui = false;
                }
            }

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsInput = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketsInput);

            Console.WriteLine("Qualified?");
            if (age > 15 && dui == false && tickets <= 3)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
                
            }

            Console.Read();
        }
    }
}
