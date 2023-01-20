using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsKeyword
{
    class Program
    {
        public void displaySubjects(params string [] subjects)
        {
            int n = subjects.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(subjects[i]);
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.displaySubjects("CN", "AI", "WebTech", "SE");
            Console.ReadKey();

        }
    }
}
