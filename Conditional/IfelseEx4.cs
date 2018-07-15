using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class IfelseEx4
    {
        static void Main(String[] args)
        {
            int marks = int.Parse(Console.ReadLine());
            if (marks < 35)
            {
                Console.WriteLine("Fail");
            }
            else if (marks >= 35 && marks < 50)
            {
                Console.WriteLine("Pass");
            }
            else if (marks >= 50 && marks < 60)
            {
                Console.WriteLine("Grade C");
            }
            else if (marks >= 60 && marks < 75)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks >= 75 && marks < 85)
            {
                Console.WriteLine("Grade A");
            }
            else
            {
                Console.WriteLine("Grade A++");
            }
            Console.ReadLine();
        }
    }
}
