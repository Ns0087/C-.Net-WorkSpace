using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Inheritance
{
    class A
    {
        //Overriding
        //internal virtual void methodA()
        //{
        //    WriteLine("Class A method");
        //}

        //Method Hiding
        internal void methodA()
        {
            Console.WriteLine("class A method");
        }
    }
}
