﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_Example_4
{
    public class Program
    {

        static public void Main()
        {

            // Creating HashSet
            // Using HashSet class
            HashSet<string> myhash1 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");

            // Creating another HashSet
            // Using HashSet class
            HashSet<string> myhash2 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash2.Add("PHP");
            myhash2.Add("C++");
            myhash2.Add("Perl");
            myhash2.Add("Java");

            // Using ExceptWith method
            myhash1.ExceptWith(myhash2);
            foreach (var ele in myhash1)
            {
                Console.WriteLine(ele);
            }

            Console.ReadKey();
        }
    }

}
