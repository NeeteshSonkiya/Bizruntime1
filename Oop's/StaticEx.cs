using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4       // static keyword
{
    class staticEx
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i = " + test.i);
            Console.WriteLine("d = " + test.d);
            Console.ReadKey();
        }
    }
    static class test
    {
        public static int i = 10;
        public static double d = 11.1;
        static test()
        {
            Console.WriteLine("value of i = " + i);
            i = 200;
            d = 100.9;
        }
    }
}
