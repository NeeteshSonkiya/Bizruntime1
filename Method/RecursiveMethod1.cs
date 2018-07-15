using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1       //First 10 natural number using recursion
{
    class RecursiveMethod1
    {
        public static int naturalnum(int n)
        {
            if (n == 11)
            {
                return 1;
            }
            else
            {
                Console.Write(n + ",");
                return naturalnum(n + 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 natural number...");
            naturalnum(0);
            Console.Read();
        }
    }
}
