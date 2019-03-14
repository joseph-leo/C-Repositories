using System;
using System.Collections.Generic;


class ExceptionHandling
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>() { 20, 80, 965, 430, 8000 };
        bool error = false;

        do
        {
            try
            {
                Console.WriteLine("Enter a divisor for this list of integers");
                int divisor = Convert.ToInt32(Console.ReadLine());

                foreach (int num in nums)
                {
                    int total = num / divisor;
                    Console.WriteLine(num + " / " + divisor + " = " + total);
                }
                error = false;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                error = true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                error = true;
            }
        }
        while (error == true);

        Console.WriteLine("\nProgram executed successfully! Have a nice day.");

        Console.Read();
    }
}

