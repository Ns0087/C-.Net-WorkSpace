using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                Console.Write("Enter Num 1 : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Enter Num 2 : ");
                b = int.Parse(Console.ReadLine());

                int c = a / b;
                Console.WriteLine("Division is : " + c);
            }
            catch(FormatException f)
            {
                Console.WriteLine("Please Enter only Numeric Value!!!");
            }
            catch(DivideByZeroException d)
            {
                Console.WriteLine("Divide by Zero is not defined!!!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception : " + e.Message);
            }
            finally { Console.WriteLine("Exception Handling is done successfully"); }

            Console.ReadKey();
        }
    }
}
