using System;

namespace ExceptionHandeling
{
    class ExceptionEx1
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 100;
                int b = 0;
                int result = a / b;
                Console.WriteLine("the division of a & b is : " + result);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1);
            }
            Console.Read();
        }
    }
}
