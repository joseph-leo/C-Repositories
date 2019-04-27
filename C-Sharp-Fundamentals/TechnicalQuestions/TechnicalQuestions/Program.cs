using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOdds());
            Console.WriteLine(SumAll());
            Console.WriteLine(Reverse());
            Console.WriteLine(RemoveRepeats());

            foreach (string item in FizzBuzz())
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        static int SumOdds()
        {
            int[] integers = new int[] { 4, 5, 8, 9, 3 };
            List<int> odds = new List<int>();

            foreach (int i in integers)
            {
                int oddCheck = i % 2;
                if (oddCheck > 0)
                {
                    odds.Add(i);
                }
            }
            return odds.Sum();
        }

        static long SumAll()
        {
            int[] ints = new int[] { 2000000, 1200000, 4, 32908200, 9082012 };
            long total = ints.Sum();
            return total;
        }

        static string Reverse()
        {
            string word = "Hello";
            List<char> reversedWord = new List<char>();
            foreach (char letter in word)
            {
                reversedWord.Add(letter);
            }
            reversedWord.Reverse();

            return string.Concat(reversedWord);
        }

        static string RemoveRepeats()
        {
            string word = "Hello";
            List<char> removeDups = new List<char>();
            foreach (char letter in word)
            {
                if (!removeDups.Contains(letter))
                {
                    removeDups.Add(letter);
                }                
            }
            return string.Concat(removeDups);
        }

        static List<string> FizzBuzz()
        {
            List<string> finalList = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    finalList.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    finalList.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    finalList.Add("Buzz");
                }
                else
                {
                    finalList.Add(i.ToString());
                }
            }
            return finalList;
        }
    }
}
