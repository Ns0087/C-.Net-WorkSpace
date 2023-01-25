using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthmetic_Task_1
{
    internal class Program
    {
        public void add<T>(T a, T b) where T : struct
        { 
            if(a is int && b is int)
            {
                Console.WriteLine("Addition is : " + (Convert.ToInt32(a) + Convert.ToInt32(b)));
            }
            else if (a is double && b is double)
            {
                Console.WriteLine("Addition is : " + (Convert.ToDouble(a) + Convert.ToDouble(b)));
            }
            else
            {
                Console.WriteLine("Please enter a Numeric Value !!");
            }
        }

        public void sub<T>(T a, T b) where T : struct
        { 
            if (a is int && b is int)
            {
                Console.WriteLine("Subtraction is : " + Math.Abs((Convert.ToInt64(a) - Convert.ToInt64(b))));
            }
            else if(a is double && b is double)
            {
                Console.WriteLine("Subtraction is : " + Math.Abs((Convert.ToDouble(a) - Convert.ToDouble(b))));
            }
            else
            {
                Console.WriteLine("Please enter a Numeric Value !!");
            }
        }

        public void mul<T>(T a, T b) where T : struct
        {
            if (a is int && b is int)
            {
                Console.WriteLine("Multiplication is : " + (Convert.ToInt64(a) * Convert.ToInt64(b)));
            }
            else if (a is double && b is double)
            {
                Console.WriteLine("Multiplication is : " + (Convert.ToDouble(a) * Convert.ToDouble(b)));
            }
            else
            {
                Console.WriteLine("Please enter a Numeric Value !!");
            }
        }

        public void divide<T>(T a, T b) where T : struct
        {
            if ((a is int && b is int) || (a is double && b is double))
            {
                Console.WriteLine("Division is : " + (Convert.ToDouble(a) / Convert.ToDouble(b)));
            }
            else
            {
                Console.WriteLine("Please enter a Numeric Value !!");
            }
        }
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine(a.GetType());
            Program obj = new Program();
            obj.add<int> (10, 20);
            obj.sub<double> (10.7, 20);
            obj.mul<int> (10, 20);
            obj.divide<int> (5, 10);
            Console.ReadKey();
        }
    }
}
