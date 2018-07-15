//Palindrome number
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LoopEx3
    {
        static void Main(String[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int number = num;
            int num1 = 0;
            while (num != 0)
            {
                int x = num % 10;
                num = num / 10;
                num1 = num1 * 10 + x;
            }
            if (number == num1)
            {
                Console.WriteLine(number + " is palindrome number");
            }
            else
            {
                Console.WriteLine(number + " is not palindrome number");
            }
            Console.ReadKey();
        }
    }
}
