using System;

namespace ConsoleApp2
{
    class IfelseEx1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to if-Block");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is even number");
            }
            else
            {
                Console.WriteLine(num + "is odd number");
            }
            Console.Read();
        }
    }
}
