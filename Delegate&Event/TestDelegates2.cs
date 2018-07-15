using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class TestDelegates2
    {
        public delegate void print(int value);

        public static void printNumber(int num)
        {
            Console.WriteLine("Number is : " + num);
        }
        public static void printMoney(int money)
        {
            Console.WriteLine("Money is : " + money);
        }
        static void Main(string[] args)
        {
            print printDel = printNumber;
            printDel(1000);
            printDel(100);
            Console.WriteLine();
            printDel = printMoney;
            printDel(1000000);
            printDel(10000);

            Console.Read();
        }
    }
}
