using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class B : A
    {
        internal void methodB()
        {
            Console.WriteLine("Class B Method");
        }

        //This method can't be further overridden
        internal sealed override void methodA()
        {
            base.methodA();
            Console.WriteLine("Class A method overridden in Class B");
        }
    }
}
