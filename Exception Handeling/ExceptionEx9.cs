using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandeling
{
    class ExceptionEx9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                throw new ApplicationException();
            }
            Console.WriteLine("Age ae valid for voting");
            Console.ReadLine();
        }
    }
}
