using System;

namespace ConsoleApp1       //clone , compare, compareOrdinal, compareTo
{
    class StringMethods3
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "application";
            string s4 = "zadye wolf";
            string s5 = (string)s3.Clone();
            Console.WriteLine("Compare().............");
            Console.WriteLine(string.Compare(s1,s2));
            Console.WriteLine(string.Compare(s1, s3));
            Console.WriteLine(string.Compare(s1, s4));
            Console.WriteLine("CompareOrdinal().............");
            Console.WriteLine(string.CompareOrdinal(s1, s2));
            Console.WriteLine(string.CompareOrdinal(s1, s3));
            Console.WriteLine(string.CompareOrdinal(s1, s4));
            Console.WriteLine("CompareTo().............");
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s1.CompareTo(s3));
            Console.WriteLine(s1.CompareTo(s4));
            Console.WriteLine("=======================");
            Console.Read();
        }
    }
}
