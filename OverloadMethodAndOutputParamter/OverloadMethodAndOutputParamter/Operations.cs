using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethodAndOutputParamter
{
    public static class Operations
    {
        public static void DivideByTwo(int x)
        {
            x = x / 2;
            Console.WriteLine("~" + x);
        }
        public static void DivideByTwo(int x, out int y)
        {
            y = x / 2;
        }
    }
}
