using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchContinued
{
    public class AgeOfZeroException : Exception
    {
        public AgeOfZeroException()
            : base() { }
        public AgeOfZeroException(string message)
            : base(message) { }
    }
}
