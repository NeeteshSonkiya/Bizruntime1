using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1       //sum of n natural number using recursion
{
    class RecursiveMethod3
    {
        public static int sumNaturalNum(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n + sumNaturalNum(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num....");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of {0} natual number....", num);
            int sum = sumNaturalNum(num);
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
