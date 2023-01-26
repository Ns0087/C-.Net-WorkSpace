using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplemented_Library
{
    public class Publisher
    {
        public delegate void MyDelegate(int a, int b);
        
        public event MyDelegate MyEvent;

        public void RaiseEvent(int a, int b)
        {
            if(this.MyEvent != null)
            {
                this.MyEvent(a, b);
            }
        }
    }
}
