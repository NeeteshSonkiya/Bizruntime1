using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1       //ToLower, ToUpper
{
    class StringMethods2
    {
        static void Main(string[] args)
        {
            string s1 = "WelComE To BiZRunTime";
            string s2 = s1.ToLower();
            string s3 = s1.ToUpper();
            Console.WriteLine("s1 = " + s1);
            Console.WriteLine("ToLower() : " + s2);
            Console.WriteLine("ToUpper() : " + s3);
            Console.Read();
        }
    }
}
