using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new B();
            obj.methodA();
            Console.ReadKey();
        }
    }
}
