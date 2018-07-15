using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandeling
{
    class ExceptionEx7
    {
        static void Main(string[] args)
        {
            int val = int.MaxValue;
            Console.WriteLine(val + 2);

            unchecked
            {
                Console.WriteLine(val + 5);
            }
            checked
            {
                Console.WriteLine(val + 8);
            }
        }
    }
}
