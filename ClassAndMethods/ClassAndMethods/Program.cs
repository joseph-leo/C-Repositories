using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNum = true;

            do
            {
                try
                {
                    Console.WriteLine("Enter a number to see some math.");
                    int x = Convert.ToInt32(Console.ReadLine());

                    int subtract = MathOps.SubtractTwo(x);
                    int multiply = MathOps.MultiplyByFour(x);
                    int power = MathOps.MultiplyByFour(x);

                    Console.WriteLine(x + " - 2 = " + subtract);
                    Console.WriteLine(x + " * 4 = " + multiply);
                    Console.WriteLine(x + "^2 = " + power);
                    isNum = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message + "\n");
                    isNum = false;
                }
                
            }
            while (!isNum);

            Console.Read();
        }
    }
}
