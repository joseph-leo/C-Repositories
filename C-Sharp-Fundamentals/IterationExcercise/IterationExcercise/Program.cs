using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] adjs = { "Crazy ", "Stinky ", "Cool ", "Tall " };

        Console.WriteLine("Enter a noun.");
        string noun = Console.ReadLine();

        for (int i = 0; i < adjs.Length; i++)
        {
            adjs[i] += noun;
            Console.WriteLine(adjs[i]);
        }


        Console.WriteLine("");


        //int i = 0;
        //while (i < 5)
        //{
        //    Console.WriteLine(i);
        //}

        int num = 0;
        while (num < 5)
        {
            Console.WriteLine(num);
            num++;
        }


        Console.WriteLine("");


        int gallons = 0;
        while (gallons < 11)
        {
            Console.WriteLine("Filling tank " + gallons.ToString() + " gallons");
            gallons++;
        }
        Console.WriteLine("Full");


        Console.WriteLine("");


        gallons = 0;
        while (gallons <= 10)
        {
            Console.WriteLine("Filling tank " + gallons.ToString() + " gallons");
            gallons++;
        }
        Console.WriteLine("Full");


        Console.WriteLine("");


        List<string> names = new List<string> { "john", "jacob", "jessica", "april", "diane", "mary", "doug" };

        Console.WriteLine("Guess a name");
        string guess = Console.ReadLine();

        List<bool> nameChecker = new List<bool>();

        for (int i = 0; i < names.Count; i++)
        {
            if (names[i] == guess)
            {
                nameChecker.Add(true);
                Console.WriteLine("That name is in position " + i.ToString() + " of the list.");
                break;
            }
            else
            {
                nameChecker.Add(false);
            }
        }
        string nameFound = nameChecker.Contains(true) ? null : "Name not found.\n";
        Console.WriteLine(nameFound);


        List<string> cars = new List<string>() { "camry", "mustang", "camry", "charger" };
        List<int> indices = new List<int>();

        Console.WriteLine("Enter the word 'camry'.");
        string userInput = Console.ReadLine().ToLower();

        if (cars.Contains(userInput))
        {
            for (int j = 0; j < cars.Count; j++)
            {
                if (cars[j] == userInput)
                {
                    indices.Add(j);
                }
            }
            Console.WriteLine("'camry' appears at position {0} and position {1}", indices[0], indices[1]);
        }
        else
        {
            Console.WriteLine("You did not write camry.");
        }


        Console.WriteLine("");


        List<string> dogs = new List<string>() { "pug", "poodle", "german shepherd", "poodle" };
        List<string> repeatChecker = new List<string>();

        foreach (string dog in dogs)
        {
            Console.WriteLine(dog + ":");
            if (repeatChecker.Contains(dog))
            {
                Console.WriteLine("Repeat\n");
            }
            else
            {
                Console.WriteLine("New\n");
            }
            repeatChecker.Add(dog);
        }


        Console.Read();
    }
}
