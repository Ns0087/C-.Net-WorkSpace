using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Constraints
{
    class Program
    {
        static void Main(string[] args)
        {
            Test<Demo> obj = new Test<Demo>();      //invalid

            Test<Demo2> obj2 = new Test<Demo2>();
            //Test<IDemo> obj3 = new Test<IDemo>();     //invalid
            //Test<string> obj4 = new Test<string>();       //invalid
            Test<ArrayList> obj5 = new Test<ArrayList>();

        }
    }

    public class Test<T> where T : new()
    {
        public T Data { get; set; }
    }

    public abstract class Demo
    {
        public Demo()
        {

        }
        public abstract void MethodA();
    }

    public class Demo2
    {
        public string DataString { get; set; }
    }

    public interface IDemo
    {
        void MyMethod();
    }
}
