using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Event_Handler_Library;

namespace Event_Handler_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.DoWork();
            Console.ReadKey();
        }

        public void DoWork()
        {
            Publisher publisher= new Publisher();
            
            publisher.myEvent += (sender, e)=> 
            {
                Console.WriteLine(e.a + e.b);
            };

            publisher.RaiseEvent(this, 19, -8);
            publisher.RaiseEvent(this, -5, 38);
            publisher.RaiseEvent(this, 14, 18);

        }
    }
}
