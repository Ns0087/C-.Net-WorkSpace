using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Predicate_Delegate_Library;

namespace Predicate_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

                
            publisher.myEvent += (a) => a >= 10;

            Console.WriteLine(publisher.RaiseEvent(18));
            Console.ReadKey();


        }
    }
}
