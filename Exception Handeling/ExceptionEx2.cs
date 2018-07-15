using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandeling
{
    class ExceptionEx2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method begin...");
            try
            {
                string str = null;
                Console.WriteLine(str.Length);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("Main method end...");
            Console.Read();
        }
    }
}
