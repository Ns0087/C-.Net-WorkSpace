using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class A
    {
        //Overriding
        internal virtual void methodA()
        {
            Console.WriteLine("Class A method");
        }

        //Method Hiding
        //internal void methodA()
        //{
        //    Console.WriteLine("Class A method");
        //}
    }
}
