﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj;
            obj= new B();
            obj.methodA();
            ReadKey();
        }
    }
}
