using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandeling
{
    class ExceptionEx4
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Main method begin ");
            try
            {
                int[] x = new int[5];
                x[6] = 11;
                Console.WriteLine(x[6]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine(" Main method end ");
            Console.ReadLine();
        }
    }
}
