using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number() { Amount = 2.0912m };
            Console.WriteLine(number.Amount);
            Console.Read();
        }
    }
}
