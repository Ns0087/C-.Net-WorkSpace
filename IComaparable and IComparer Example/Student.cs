using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComaparable_and_IComparer_Example
{
    internal class Student : IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public double Marks { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Sid < other.Sid) return -1;
            else if (this.Sid > other.Sid) return 1;
            else return 0;
        }
    }

    public class StudentCompare : IComparer<Student>
    {
        int IComparer<Student>.Compare(Student x, Student y)
        {
            if(x.Marks< y.Marks) return -1;
            else if(x.Marks > y.Marks) return 1;
            else return 0;
        }
    }
}
