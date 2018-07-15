using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void multicastDel(int num);
    class MultiCastDelegate
    {
        public static void printNumber(int number)
        {
            Console.WriteLine("Number is : " + number);
        }
        public static void printMoney(int money)
        {
            Console.WriteLine("Money is : " + money);
        }
        static void Main(string[] args)
        {
            multicastDel md = new multicastDel(printNumber);
            md += new multicastDel(printMoney);

            md(1000);
            Console.WriteLine();
            md -= new multicastDel(printMoney);
            md(19);
            Console.Read();
        }
    }
}
