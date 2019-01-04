using System;

namespace MathPractice
{
    class MathPractice
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            string firstNum = Console.ReadLine();
            long firstTotal = Convert.ToInt64(firstNum) * 50;
            Console.WriteLine(firstNum + " * 50 = " + firstTotal.ToString());
            Console.WriteLine("");

            Console.WriteLine("Enter a new number: ");
            string secondNum = Console.ReadLine();
            int secondTotal = Convert.ToInt32(secondNum) + 25;
            Console.WriteLine(secondNum + " + 25 = " + secondTotal.ToString());
            Console.WriteLine("");

            Console.WriteLine("Enter a third number: ");
            string thirdNum = Console.ReadLine();
            float thirdTotal = Convert.ToSingle(thirdNum) / 12.5f;
            Console.WriteLine(thirdNum + " / 12.5 = " + thirdTotal.ToString());
            Console.WriteLine("");

            Console.WriteLine("Enter a fourth number: ");
            string fourthNum = Console.ReadLine();
            bool greaterThan = Convert.ToInt32(fourthNum) > 50;
            Console.WriteLine("Greater than 50? " + greaterThan);
            Console.WriteLine("");

            Console.WriteLine("Enter your final number: ");
            string fifthNum = Console.ReadLine();
            int remainder = Convert.ToInt32(fifthNum) % 7;
            Console.WriteLine("The remainder of " + fifthNum + " / 7 = " + remainder.ToString());
            Console.Read();
        }
    }
}
