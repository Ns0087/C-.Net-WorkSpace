using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedArguments
{
    class Program
    {
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static void Main(string[] args)
        {
            MyMethod(child3: "John", child1: "Liam", child2: "Liam");
            Console.ReadKey();
        }
    }
}
