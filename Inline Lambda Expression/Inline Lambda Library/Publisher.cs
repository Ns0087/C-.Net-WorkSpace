using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inline_Lambda_Library
{
    public class Publisher
    {
        public delegate int MyDelegate(int a, int b);

        public event MyDelegate MyEvent;

        public int RaiseEvent(int a, int b)
        {
            if (this.MyEvent != null)
            {
                return this.MyEvent(a, b);
            }
            return 0;
        }
    }

}
