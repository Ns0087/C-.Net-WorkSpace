using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Function
{
    class Program
    {
        public void displayMarks(int m1, int m2, int m3)
        {
            double avgMarks = getAverage();
            Console.WriteLine("Marks 1 : " + m1);
            Console.WriteLine("Marks 2 : " + m2);
            Console.WriteLine("Marks 1 : " + m1);
            Console.WriteLine("Average Marks : " + avgMarks);

            double getAverage()
            {
                double avg;
                avg = (double)(m1 + m2 + m3)/3;
                return avg;
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.displayMarks(80, 85, 78);
            Console.ReadKey();
        }
    }
}
