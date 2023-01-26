using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Delegate_Library
{
    public class Publisher
    {
        public event Predicate<int> myEvent;

        public bool RaiseEvent(int a)
        {
            if(myEvent != null)
            {
                return myEvent(a);
            }

            return false;
        }
    }
}
