using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpilicitInterfaceImplementation
{
    interface IPerson
    {
        System.DateTime DOB { get; set; }
        int GetAge();
    }
}
