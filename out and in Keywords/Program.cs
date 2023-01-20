using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_and_in_Keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b, c = 20;

            Console.WriteLine("a before - " + a);
            Console.WriteLine("b is not assigned any value yet");
            Console.WriteLine("c before - " + c);

            Add(in a, out b, ref c);

            Console.WriteLine("a - " + a);
            Console.WriteLine("b - " + b);
            Console.WriteLine("c - " + c);
            Console.ReadKey();
        }

        public static void Add(in int a, out int b, ref int c)
        {
            b = a + c;
            c = a + b + c;
        }
    }
}
