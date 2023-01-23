using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpilicitInterfaceImplementation
{
    interface IEmployee
    {
        int EmpID { get; set; }
        string EmpName { get; set; }
        string Location { get; set; }
        int GetAge();
    }
}
