using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandeling
{
    class ExceptionEx3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 1st number ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd number ");
                int b = int.Parse(Console.ReadLine());
                int result = a / b;
                Console.WriteLine("the division of a & b is : " + result);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex);
            }
            Console.Read();
        }
    }
}
