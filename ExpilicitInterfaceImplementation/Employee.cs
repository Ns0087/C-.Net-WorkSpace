using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpilicitInterfaceImplementation
{
    class Employee : IEmployee, IPerson
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Location { get; set; }
        public DateTime DOB { get; set; }

        int IPerson.GetAge()
        {
            int a = System.Convert.ToInt32((System.DateTime.Now - DOB).TotalDays / 365);
            return a;
        }
        int IEmployee.GetAge()
        {
            return 20;
        }
    }
}
