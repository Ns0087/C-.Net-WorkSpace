using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "1001";
            string str2 = "100 1";
            bool flag1 = int.TryParse(str1, out int b);
            Console.WriteLine(flag1);
            bool flag2 = int.TryParse(str2, out int c);
            Console.WriteLine(flag2);

            Console.ReadKey();
        }
    }
}
