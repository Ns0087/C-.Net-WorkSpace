using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    internal class Program
    {
        public static void add(int a)
        {
            a += 10;
        }

        public static void sub(ref int a)
        {
            a -= 5;
        }

        public static void check(in int b, out int a)
        {
            a = 14 + b;
            //b = a;
        }

        static void Main(string[] args)
        {
            int a, b, c = 100;
            a = 12;
            b = 13;

            Console.WriteLine("Before a : " + a + " b : " + b);

            add(a);
            sub(ref b);

            Console.WriteLine("After a : " + a + " b : " + b);

            check(in b, out c);

            Console.WriteLine("After a : " + a + " b : " + b + " c : " + c);

            //Extension Method

            Class1 class1 = new Class1
            {
                a = 13,
                b = 14
            };

            Console.WriteLine("Extension Methods Example : " + class1.Add("nitin", class1.b));

            Console.ReadKey();

        }
    }
}
