using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_and_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //primitive variable
            int x = 10;

            //boxing(value-type to refernce type)
            object obj = x;     //obj is refernce type

            //Unboxing
            //int y = Convert.ToInt32(obj);
            int y = (int)obj;

            Console.WriteLine(x);
            Console.WriteLine(obj);
            Console.ReadKey();

        }
    }
}
