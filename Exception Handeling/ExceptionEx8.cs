using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandeling
{
    class ExceptionEx8
    {
        static void Main(string[] args)
        {
            unchecked
            {
                Console.WriteLine("Enter 1st number..");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd number..");
                int b = int.Parse(Console.ReadLine());
                int result = a / b;
                Console.WriteLine(result);
            }
            checked
            {
                string str = null;
                Console.WriteLine(str.Length);
            }
            Console.Read();
        }
    }
}
