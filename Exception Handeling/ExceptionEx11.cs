using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExceptionHandeling
{
    class ExceptionEx11
    {
        static void callIndexOutOfRangeException()
        {
            int[] x = new int[10];
            x = new int[] { 10, 11, 111, 1111, 121, 212, 323, 3231, 43 };
            Console.WriteLine(x[10]);

        }
        static void callNullReferanceException()
        {
            string str = null;
            Console.WriteLine(str.Length);
           
        }
        static void callArgumentException(string str)
        {
            //int i = null; 
            var dictionary = new Dictionary<string, int>();
            int value = dictionary[null];

        }
        static void Main(string[] args)
        {
            //          callIndexOutOfRangeException();
            //          callNullReferanceException();
            callArgumentException(null); 
             Console.Read();
        }
    }
}
