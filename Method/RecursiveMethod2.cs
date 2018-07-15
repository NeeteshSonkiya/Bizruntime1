using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RecursiveMethod2
    {
        public static int reverse(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                Console.Write(n + ",");
                return reverse(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse number series...");
            int num = int.Parse(Console.ReadLine());
            reverse(num);
            Console.ReadKey();
        }
    }
}
