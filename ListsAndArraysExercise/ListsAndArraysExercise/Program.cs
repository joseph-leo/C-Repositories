using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] colors = new string[] { "blue", "red", "green", "yellow", "purple"};

        Console.WriteLine("Please enter a number 0-4 to see a color.");

        int i = 0;

        do
        {
            try
            {
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(colors[i] + "\n");
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Number out of range. Pick a number 0-4.");
            }
        }
        while (i > 4);

        int[] nums = new int[] { 80, 43, 54, 7, 1, 65, 87 };

        Console.WriteLine("Please enter a number 0-6.");

        int j = 0;

        do
        {
            try
            {
                j = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(nums[j] + "\n");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Number out of range. Pick a number 0-6.");
            }
        }
        while (j > 6);

        List<string> states = new List<string>() { "Montana", "Oregon", "Texas", "Alabama", "Tennesse", "Maine"};

        Console.WriteLine("Please enter a number 0-5");

        int n = 0;

        do
        {
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(states[n]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Number out of range. Pick a number 0-5");
            }
        }
        while (n > 5);

        Console.Read();
    }
}
