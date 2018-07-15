using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class EnumsEx
    {
        public enum Days {sun, mon=10, tue, wed, thu, fri, sat};

        static void Main(string[] args)
        {
            Console.WriteLine("sun = " + (int)Days.sun);            //printing value in integer
            Console.WriteLine("mon = " + Days.mon);                 //print value 
            foreach (string s in Enum.GetNames(typeof(Days)))       //iterate enum by names
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
