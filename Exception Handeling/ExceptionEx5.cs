using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandeling
{
    class ExceptionEx5 : Exception
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finally block executing ");
            }
            Console.ReadLine();
        }
    }
}
