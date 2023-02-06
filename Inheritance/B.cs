using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Inheritance
{
    class B : A
    {
        internal void methodB()
        {
            WriteLine("Class B Method");
        }

        //This method can't be further overridden
        //internal sealed override void methodA()
        //{
        //    base.methodA();
        //    WriteLine("Class A method overridden in Class B");
        //}

        //Method Hiding
        internal new void methodA()
        {
            WriteLine("Class A method overridden in Class B");
        }
    }
}
