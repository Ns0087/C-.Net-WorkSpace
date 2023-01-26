using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoImplemented_Library;

namespace Anonymous_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            publisher.MyEvent += delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };

            publisher.RaiseEvent(12, 45);
            Console.ReadKey();
        }
    }
}
