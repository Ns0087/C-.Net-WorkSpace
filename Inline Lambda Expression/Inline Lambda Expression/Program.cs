using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inline_Lambda_Library;

namespace Inline_Lambda_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            publisher.MyEvent += (a, b) => a + b;

            Console.WriteLine(publisher.RaiseEvent(20, 13));

            Console.ReadKey();
        }
    }
}
