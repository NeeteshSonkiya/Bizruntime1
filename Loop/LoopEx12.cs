using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LoopEx12
    {
        static void Main(String[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                sum += num % 10;
                num = num / 10;
            }
            while (num != 0);
            Console.WriteLine("sum the digits is : " + sum);
            Console.ReadKey();
        }
    }
}
