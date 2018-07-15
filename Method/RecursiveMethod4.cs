using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1   //printing seprate digit using recusion
{
    class RecursiveMethod4
    {
        public static void seprateDigit(int n)
        {
            if (n < 10)
            {
                Console.Write(n + " ");
                return;
            }
            seprateDigit(n / 10);
            Console.Write( n %10 + " ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number..");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(" The Seprate Digit of the {0} is : ", num);
            seprateDigit(num);
            Console.Read();
        }
    }
}
