using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LoopEx11
    {
        static void Main(String[] args)
        {
        ineligible:
            Console.WriteLine("You are not eligible for the vote ");
            Console.WriteLine("Enter your age :....");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You are eligible for vote ");
            }
            Console.ReadKey();
        }
    }
}
