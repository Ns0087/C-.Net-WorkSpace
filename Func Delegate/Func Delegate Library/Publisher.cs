using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Delegate_Library
{

    public class Publisher
    {
        public event Func<int, int, int> myEvent;

        public int RaiseEvent(int a, int b)
        {
            if (myEvent != null) { return myEvent(a, b); }
            return 0;
        }
    }
}
