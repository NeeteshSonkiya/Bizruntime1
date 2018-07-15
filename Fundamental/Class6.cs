using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class6
    {
        static void Main(String[] args)
        {
            int i = 10;
            int j = i++;
            int k = ++j;

            Console.WriteLine("value of i = " + i);
            Console.WriteLine("value of j = {0}", j);
            Console.WriteLine("value of k = " + k);
            Console.Read();
        }
    }
}
