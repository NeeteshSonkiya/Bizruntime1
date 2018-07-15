using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public enum wheather{
        WINTER, SUMMER, RAINNING
    }
    class EnumsEx1
    {
        static void Main(string[] args)
        {
            foreach(int s in Enum.GetValues(typeof(wheather)))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("===================");
            foreach(string s in Enum.GetNames(typeof(wheather)))
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
