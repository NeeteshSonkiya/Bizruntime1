//sum of the digit
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LoopEx7
    {
        static void Main(String[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
