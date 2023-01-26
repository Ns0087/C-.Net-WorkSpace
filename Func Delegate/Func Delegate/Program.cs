using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Func_Delegate_Library;

namespace Func_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            publisher.myEvent += (a, b) => a + b;

            Console.WriteLine(publisher.RaiseEvent(10, 22));

            Console.ReadKey();
        }
    }
}
