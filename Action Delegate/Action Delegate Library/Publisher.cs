using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate_Library
{
    public class Publisher
    {
        public event Action<int, int> OnCompleted;

        public void RaiseEvent(int a, int b)
        {
            if(OnCompleted != null)
            {
                OnCompleted(a, b);
            }
        }
    }
}
