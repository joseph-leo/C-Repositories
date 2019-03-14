using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsContinued
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = Operations.Op(12);
            decimal second = Operations.Op(32.01m);
            string third = Operations.Op("6");

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);

            Console.Read();
        }
    }
}
