using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethodAndOutputParamter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to divide by 2.");
            int x = Convert.ToInt32(Console.ReadLine());

            Operations.DivideByTwo(x);

            Operations.DivideByTwo(x, out int y);
            int z = y;

            Console.WriteLine(z);

            Console.Read();
        }
        
    }
}
