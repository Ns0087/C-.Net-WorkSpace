using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propert_Matching
{
    internal class Program
    {
        public static void DescribeStringLength(string str)
        {

            // Constant pattern, discussed further
            if (str is null)
            {
                Console.WriteLine("Null string");
            }

            if (str is { Length: 0 })
            {
                Console.WriteLine("Empty string");
                return;
            }

            if (str is { Length: 1 })
            {
                Console.WriteLine("String of length 1");
                return;
            }

            Console.WriteLine("Length greater than 1");
            return;
        }

        // Driver code
        public static void Main()
        {
            DescribeStringLength("Hello!");
            Console.WriteLine();
            DescribeStringLength("");
            Console.WriteLine();
            DescribeStringLength("X");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
