using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action_Delegate_Library;

namespace Action_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            publisher.OnCompleted += delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };

            publisher.RaiseEvent(23, 98);

            Console.ReadKey();
        }
    }
}
