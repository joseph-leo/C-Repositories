using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> empString = new Employee<string>();
            empString.Things = new List<string>() { "Hi", "Joe", "no" };
            List<string> stringList = empString.Things;

            Employee<int> empInt = new Employee<int>();
            empInt.Things = new List<int>() { 2, 4, 6, 8 };
            List<int> intList = empInt.Things;



            foreach (string word in stringList)
            {
                Console.WriteLine(word);
            }

            foreach (int num in intList)
            {
                Console.WriteLine(num);
            }

            Console.Read();
        }
    }
}
