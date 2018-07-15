using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandeling
{
    class ExceptionEx6
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            try
            {
                x[100] = 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("finally executed");
            }
            Console.Read();
        }
    }
}
