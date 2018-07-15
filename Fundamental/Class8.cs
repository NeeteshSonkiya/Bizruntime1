using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class8
    {
        static void Main(String[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            Console.WriteLine("sum of digit is = " + sum);
            Console.ReadLine();
        }

    }
}
