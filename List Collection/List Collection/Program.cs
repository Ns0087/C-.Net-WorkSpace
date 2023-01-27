using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Capacity of List : {0}", list.Capacity);

            list.Add(1);
            Console.WriteLine("Capacity of List : {0}", list.Capacity);

            list.Add(2);
            Console.WriteLine("Capacity of List : {0}", list.Capacity);

            list.Add(3);
            Console.WriteLine("Capacity of List : {0}", list.Capacity);

            list.Add(4);
            list.Add(5);
            list.Add(6);
            Console.WriteLine("Capacity of List : {0}", list.Capacity);

            list.Add(7);
            list.Add(8);
            list.Add(9);
            Console.WriteLine("Capacity of List : {0}", list.Capacity);

            list.Add(10);
            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);
            list.Add(16);
            list.Add(17);

            foreach (int i in list) { 
                Console.WriteLine(i);
            }

            //Capacity of List
            Console.WriteLine("Capacity of List : {0}", list.Capacity);

            //Size of List
            Console.WriteLine("Size of List : {0}", list.Count);
            Console.ReadKey();
        }
    }
}
