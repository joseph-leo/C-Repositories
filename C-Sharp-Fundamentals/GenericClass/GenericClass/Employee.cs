﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }

    }
}
