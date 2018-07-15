using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Student1
    {
        public Student1()
        {
            Console.WriteLine("Default constructor Invoked");
        }
        static void Main(String[] args)
        {
            Student1 s1 = new Student1();
            Student1 s2 = new Student1();
            Console.ReadKey();
        }
    }
}
