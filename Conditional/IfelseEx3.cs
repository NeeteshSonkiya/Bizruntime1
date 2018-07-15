using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class IfelseEx3
    {
        static void Main(String[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int breadth = int.Parse(Console.ReadLine());

            if (length == breadth)
            {
                Console.WriteLine("its a square");
            }
            else
            {
                Console.WriteLine("its a rectangle");
            }
            Console.Read();
        }
    }
}
