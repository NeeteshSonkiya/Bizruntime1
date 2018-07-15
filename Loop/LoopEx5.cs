//Prime number
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LoopEx5
    {
        static void Main(String[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <= (num / 2); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(num + " is a prime number ");
            }
            else
            {
                Console.WriteLine(num + " is not a Prime number");
            }
            Console.ReadKey();
        }
    }
}
