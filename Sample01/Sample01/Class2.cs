using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public static class Class2
    {
        public static int Add(this Class1 class1, dynamic a, int b)
        {
            if(a is int)
            {
                return a + b;
            }
            return b;
        }
    }
}
