using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1       //Equals, EndWith
{
    class StringMethods1
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "llo";
            Console.WriteLine( s1.Equals(s2));
            Console.WriteLine(s1.EndsWith(s3));
            Console.Read();
        }
    }
}
