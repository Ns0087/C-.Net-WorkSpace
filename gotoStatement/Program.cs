using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotoStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("One");
            Console.WriteLine("Two");
            goto mylabel;
            Console.WriteLine("Three");
            mylabel:
            Console.WriteLine("Four");
            Console.WriteLine("Five");

            Console.ReadKey();
        }
    }
}
