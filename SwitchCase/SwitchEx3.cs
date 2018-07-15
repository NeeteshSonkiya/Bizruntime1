using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SwitchEx3
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            switch (s)
            {
                case "B":
                    Console.WriteLine("From Banglore");
                    break;
                case "D":
                    Console.WriteLine("From Delhi");
                    break;
                case "C":
                    Console.WriteLine("From Chennai");
                    break;
                case "M":
                    Console.WriteLine("From Mumbai");
                    break;
                default:
                    Console.WriteLine("Not From metro city");
                    break;
            }
            Console.ReadKey();
        }
    }
}
