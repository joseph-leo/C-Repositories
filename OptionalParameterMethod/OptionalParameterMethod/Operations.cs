using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterMethod
{
    class Operations
    {
        public static int Multiply(int x, int y = 8)
        {
            int total = x * y;
            return total;
        }
    }
}
