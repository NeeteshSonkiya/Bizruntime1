using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    //Subcriber
    class Number
    {
        private PrintHelper _printHelper;

        public Number(int val)
        {
            _value = val;
            _printHelper = new PrintHelper();
            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
            
        }
        void printHelper_beforePrintEvent()
        {
            Console.WriteLine("Before PrintEventHandler : Print Helper is going to print a value");
        }

        public int _value;
        public int value
        {
            get { return _value; }
            set { _value = value; }
        }
        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }
        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }
    }
    //Publisher
    public class PrintHelper
    {
        public delegate void BeforePrint();
        public event BeforePrint beforePrintEvent;
        public PrintHelper()
        {

        }
        public void PrintNumber(int num)
        {
            if (beforePrintEvent != null)
               beforePrintEvent();
            Console.WriteLine("Number : " + num);
        }
        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();
            Console.WriteLine("Decimal : " + dec);
        }
        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();
            Console.WriteLine("Money : " + money);
        }
        public void PrintTempature(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();
            Console.WriteLine("Temperature : " + num);
        }
    }
    class Delegates_Event2
    {
        static void Main(string[] args)
        {
            Number number = new Number(10000);
            number.PrintMoney();
            number.PrintNumber();
            Console.Read();
        }
    }
}
