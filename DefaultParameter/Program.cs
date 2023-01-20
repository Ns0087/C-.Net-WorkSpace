using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultParameter
{
    class Program
    {
        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static void Main(string[] args)
        {
            MyMethod("Sweden");
            MyMethod("India");

            //Default Parameter
            MyMethod();
            MyMethod("USA");

            Console.ReadKey();
        }
    }
}
