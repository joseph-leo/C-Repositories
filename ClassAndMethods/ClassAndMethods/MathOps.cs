using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    class MathOps
    {
        public static int SubtractTwo(int x)
        {
            int total = x - 2;
            return total;
        }
        public static int MultiplyByFour(int x)
        {
            int total = x * 4;
            return total;
        }
        public static int PowerOfTwo(int x)
        {
            int total = Convert.ToInt32(Math.Pow(x, 2));
            return total;
        }
    }
}
