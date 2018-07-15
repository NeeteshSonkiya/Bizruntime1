using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RecursiveMethod
    {
        public static int fact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * fact(n-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number...");
            int num = int.Parse(Console.ReadLine());
            int fnum = fact(num);
            Console.WriteLine("Factorial of {0}  is {1}", num, fnum);
            Console.Read();
        }
    }
}
