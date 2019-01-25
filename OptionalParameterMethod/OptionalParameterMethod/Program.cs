using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number to multiply by the first.\nYou can just press enter and the default will be 8.");
            string yInput = Console.ReadLine();
            int y;

            if (yInput.Length > 0)
            {
                try
                {
                    y = Convert.ToInt32(yInput);
                    Console.WriteLine(Operations.Multiply(x, y));
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine(Operations.Multiply(x));
            }

            Console.Read();
        }
    }
}
