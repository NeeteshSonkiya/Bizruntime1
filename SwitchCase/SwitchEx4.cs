using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SwitchEx4
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Choose an option...");
            Console.WriteLine("1. Addition ");
            Console.WriteLine("2. Substraction ");
            Console.WriteLine("3. Multipication ");
            Console.WriteLine("4. Division ");
            Console.WriteLine("Press key...");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of a..");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b...");
            int b = int.Parse(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.WriteLine(a+b);
                    break;
                case 2:
                    Console.WriteLine(a - b);
                    break;
                case 3:
                    Console.WriteLine(a * b);
                    break;
                case 4:
                    Console.WriteLine(a / b);
                    break;
            }
            Console.ReadKey();
        }
    }
}
