using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Matching_Library;

namespace Pattern_Matching_Example
{
    class Program
    {
        static void Main()
        {
            //refernce Variable
            ParentClass pc;

            //Object of child class
            pc = new ChildClass() { x = 10, y = 20 };

            //access parent class's members
            Console.WriteLine(pc.x);
            if(pc is ChildClass cc)
            {
                Console.WriteLine(cc.y);
            }
            Console.ReadKey();
        }
    }
}
