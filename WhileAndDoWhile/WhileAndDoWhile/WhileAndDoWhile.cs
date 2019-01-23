using System;

namespace WhileAndDoWhile
{
    class WhileAndDoWhile
    {
        static void Main(string[] args)
        {
            int numOne = 0;
            int numTwo = 0;

            do
            {
                Console.WriteLine("Please enter the same number twice:");

                Console.WriteLine("Number 1:");
                numOne = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Number 2:");
                numTwo = Convert.ToInt32(Console.ReadLine());
            }
            while (numOne != numTwo);

            Console.WriteLine("Thank you for following instructions.");

            Console.WriteLine("");

            Console.WriteLine("What is the capital of Montana?");
            string capital = Console.ReadLine().ToLower();
            string answer = "helena";
            bool correct = false;

            while (!correct)
            {
                Console.WriteLine("Try Again!");
                capital = Console.ReadLine().ToLower();
                correct = capital == answer;
            }
            Console.WriteLine("You are correct.");
            Console.Read();
        }
    }
}
