using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Delegates_Event4
    {
        public delegate void myDel(int num1, int mun2);
        public static event myDel myEvent;
        static double result;
        static void Main(string[] args)
        {
            myDel md = add;
            md += sub;
            md += mul;
            md += div;

            myEvent += md;
            myEvent(100, 10);
            Console.Read();
        }
        public static void add(int num1, int num2)
        {
            result = num1 + num2;
            Console.WriteLine("The addition of {0} and {1} is      : {2}  " , num1, num2, result);
        }
        public static void sub(int num1, int num2)
        {
            result = num1 - num2;
            Console.WriteLine("The subtraction of {0} and {1} is   : {2} ", num1, num2, result);
        }
        public static void mul(int num1, int num2)
        {
            result = num1 * num2;
            Console.WriteLine("The multipication of {0} and {1} is : {2} ", num1, num2, result);
        }
        public static void div(int num1, int num2)
        {
            result = num1 / num2;
            Console.WriteLine("The division of {0} and {1} is      : {2} ", num1, num2, result);
        }
    }
}
