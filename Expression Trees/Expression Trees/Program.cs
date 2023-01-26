using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create expression tree with Func
            Expression<Func<int, int>> expression = a => a*a;

            //Compile expression
            Func<int, int> myDelegate = expression.Compile();

            //Execute expression
            int result = myDelegate.Invoke(10);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
