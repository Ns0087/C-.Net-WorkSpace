using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handler_Library
{
    public class CustomEventArgs : EventArgs
    {
        public int a { get; set; }
        public int b { get; set; }
    }
    public class Publisher
    {
        public EventHandler<CustomEventArgs> myEvent;

        public void RaiseEvent(object sender, int a, int b)
        {
            if(myEvent != null)
            {
                CustomEventArgs customEventArgs= new CustomEventArgs() { a = a, b = b};
                myEvent(sender, customEventArgs);
            }
        }
    }
}
