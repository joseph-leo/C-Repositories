using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNum;

            do
            {
                try
                {
                    string path = @"C:\Users\Joseph Leonard\Documents\GitHub\The-Tech-Academy-C-Sharp-Coding-Projects\Logs\num.txt";
                    Console.WriteLine("Enter an integer.");
                    int inputNum = Convert.ToInt32(Console.ReadLine());
                    File.WriteAllText(path, inputNum.ToString());
                    string num = File.ReadAllText(path);
                    Console.WriteLine(num);
                    isNum = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer value.");
                    isNum = false;
                }
            }
            while (!isNum);

            Console.Read();
        }
    }
}
