using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoImplemented_Library;

namespace Lambda_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            publisher.MyEvent += (a, b) =>
            {
                Console.WriteLine(a + b);
            };

            publisher.RaiseEvent(65, 12);
            Console.ReadKey();
        }
    }
}
