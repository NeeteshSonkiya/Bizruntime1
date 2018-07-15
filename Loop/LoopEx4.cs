//Fibonacci Series
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LoopEx4
    {
        static void Main(String[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write(a + "," + b);
            while (c < 500)
            {
                c = a + b;
                Console.Write("," + c);
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
