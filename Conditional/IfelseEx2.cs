using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class IfelseEx2
    {
        static void Main(String[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && b > c)
            {
                Console.WriteLine(a + " is greatest number");
            }
            else if (a < b && b < c)
            {
                Console.WriteLine(c + " is greatest number");
            }
            else if (b > a && a > c)
            {
                Console.WriteLine(b + " is greatest number");
            }
            Console.Read();
        }
    }
}
