using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class7
    {
        static void Main(String[] args)
        {
            int a = 15;
            int b = ++a;
            int c = a++ + ++b + ++a - a;

            Console.WriteLine("value of a = " + a);
            Console.WriteLine("value of b = " + b);
            Console.WriteLine("value of c = " + c);
            Console.Read();
        }
    }
}
