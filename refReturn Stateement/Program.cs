using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refReturn_Stateement
{
    class Program
    {
        public int grade = 2;

        public void printGrade()
        {
            Console.WriteLine("Grade = " + grade);
        }

        //method with ref return
        public ref int doWork()
        {
            return ref grade;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.printGrade();

            //call doWork
            ref int g = ref obj.doWork();

            g = 5;

            obj.printGrade();   //expected 5
            Console.ReadKey();
        }
    }
}
