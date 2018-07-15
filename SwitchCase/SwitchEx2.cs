using System;

namespace ConsoleApp1
{
    class SwitchEx2
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                case 50:
                    Console.WriteLine("Number is 50");
                    break;
                default:
                    Console.WriteLine("Number not allow");
                    break;
            }
            Console.ReadLine();
        }
    }
}
