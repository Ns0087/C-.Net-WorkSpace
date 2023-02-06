using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Writer_EXample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\abhad\Desktop\Practice\Aa.txt";
            FileInfo fileInfo = new FileInfo(filepath);

            //write
            StreamWriter writer = fileInfo.CreateText();
            writer.WriteLine("This file has been created using StreamWriter.");
            writer.Close();

            //Append
            writer = fileInfo.AppendText();
            writer.WriteLine("A line has been appended to this file.");
            writer.Close();

            StreamReader reader = new StreamReader(filepath);
            //string content = reader.ReadToEnd();
            //reader.Close();
            //Console.WriteLine(content);

            char[] buffer = new char[10];
            reader.Read(buffer, 0, buffer.Length);

            StringBuilder sb = new StringBuilder();
            foreach(char c in buffer)
            {
                sb.Append(c);
            }
            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}
