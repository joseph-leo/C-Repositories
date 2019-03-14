using System;

namespace ConstVarAndChainConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const double divisor = 6.0;
            Console.WriteLine("Enter a number to divide by 6.");
            double dividend = Convert.ToInt32(Console.ReadLine());

            Division division1 = new Division(dividend, divisor);
            Division division2 = new Division(dividend);

            var firstTotal = division1.Dividend / division1.Divisor;
            var secondTotal = division2.Dividend / division2.Divisor;

            Console.WriteLine(firstTotal);
            Console.WriteLine(secondTotal);

            Console.Read();
        }
    }
}
