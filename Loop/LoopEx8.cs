// reverse number
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LoopEx8
    {
        static void Main(String[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = 0;
            while (num != 0)
            {
                int x = num % 10;
                num = num / 10;
                num1 = num1 * 10 + x;
            }
            Console.WriteLine(num1);
            Console.ReadKey();
        }
    }
}
