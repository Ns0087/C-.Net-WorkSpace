using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 101, FirstName = "Nitin", LastName = "Saraswat", Age = 23, Course = "MCA" });
            students.Add(new Student() { Id = 102, FirstName = "Abhishek", LastName = "Jha", Age = 23, Course = "BTech" });
            students.Add(new Student() { Id = 103, FirstName = "Suraj", LastName = "Pandey", Age = 28, Course = "MCA" });
            students.Add(new Student() { Id = 104, FirstName = "Ankit", LastName = "Kumar", Age = 22, Course = "MBA" });
            students.Add(new Student() { Id = 105, FirstName = "Aayush", LastName = "Kumar", Age = 24, Course = "BCA" });

            PropertyInfo[] properties = typeof(Student).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.Write(property.Name + "                            ");
            }

            Console.WriteLine();

            //Console.WriteLine(properties.Length);
            foreach (Student student in students)
            {
                Console.WriteLine(student.Id + "                     " + student.FirstName + "                     " + student.LastName + "                          " +
                    student.Age + "                     " + student.Course);
            }
            Console.ReadKey();

            
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Course { get; set;}

    }
}
