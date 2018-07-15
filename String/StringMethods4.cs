using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1       // copy, concat, contains
{
    class StringMethods4
    {
        static void Main(string[] args)
        {
            string s1 = "Hello ";
            string s2 = "String";
            string s3 = string.Copy(s1);
            Console.WriteLine("s3 = " + s3);
            Console.WriteLine(string.Concat(s1,s2));
            Console.WriteLine(s1.Contains(s3));
            Console.Read();
        }
    }
}
