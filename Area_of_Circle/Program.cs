using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter the radius = ");
                int r = Convert.ToInt32(Console.ReadLine());

                double area = 3.14 * r * r;
                Console.WriteLine("Area of Circle is = " + area);
                Console.ReadKey();
        }
    }
}
