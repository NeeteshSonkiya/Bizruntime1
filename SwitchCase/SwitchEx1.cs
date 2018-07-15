using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SwitchEx1
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Which one is correct ..?");
            Console.WriteLine("a. int i = 10.0;");
            Console.WriteLine("b. double d = 20.1;");
            Console.WriteLine("c. float f = 22.2f;");
            Console.WriteLine("d. string s = 'fsfs'");
            Console.WriteLine("Choose the answer.......");
            char ans = (char)Console.Read();
            switch (ans)
            {
                case 'a':
                    Console.WriteLine("Invalid answer");
                    break;
                case 'b':
                    Console.WriteLine("Invalid answer");
                    break;
                default:
                    Console.WriteLine("Not Allow");
                    break;
                case 'c':
                    Console.WriteLine("Correct answer");
                    break;
                case 'd':
                    Console.WriteLine("Invalid answer");
                    break;
               
            }
            Console.ReadKey();
        }
    }
}
