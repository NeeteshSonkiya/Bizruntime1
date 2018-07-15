using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1           //Counting space in a string
{
    class MethodEx1
    {
        public int str(string s1)
        {
            int count = 0;
            string st1 = "";
            for (int i = 0; i < s1.Length; i++)
            {
                st1 = s1.Substring(i, 1);
                if (st1 == " ")
                {
                    count++;
                }
            }
            Console.WriteLine("count = " + count);
            return count;
        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            MethodEx1 c1 = new MethodEx1();
            int c = c1.str(s1);
            Console.ReadKey();
        }
    }
}
