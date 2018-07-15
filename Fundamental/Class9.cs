using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class9
    {
        int i = 10;
        static int j = 32;
        const float Pi = 3.14f;
        static void Main(String[] args)
        {
            Class9 c9 = new Class9();
            c9.i = 14;
            j = 23;
            Console.WriteLine("value of i = " + c9.i);
            Console.WriteLine("value of j = " + j);
            Console.WriteLine("value of Pi = " + Pi);
            Console.ReadLine();
        }
    }
}
