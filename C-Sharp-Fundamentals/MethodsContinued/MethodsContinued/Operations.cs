using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsContinued
{
    class Operations
    {
        public static int Op(int x)
        {
            x = x + 12;
            return x;
        }
        public static decimal Op(decimal x)
        {
            x = Convert.ToInt32(x) * 6;
            return x;
        }
        public static string Op(string x)
        {
            try
            {
                int total = Convert.ToInt32(x) - 8;
                return total.ToString();
            }
            catch (FormatException e)
            {
                return e.Message;
            }
        }
    }
}
