using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1   //split,trim,substring, indexOf, length
{
    class StringMethods5
    {
        static void Main(string[] args)
        {
            string s1 = " hello guys! how'z your day ";
            string s2 = s1.Trim();
            string[] s3 = s1.Split(" ");
            string s4 = s1.Substring(3, 8);
            int i = s1.IndexOf("!");
            Console.WriteLine("s1 is : " + s1);
            Console.WriteLine("s2 is : " + s2);
            Console.Write("s3 is : ");
            foreach(string c in s3)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            Console.WriteLine("s4 is : " + s4);
            Console.WriteLine("i = " + i);
            Console.WriteLine("s1 length is : " + s1.Length);
            Console.Read();
        }
    }
}
