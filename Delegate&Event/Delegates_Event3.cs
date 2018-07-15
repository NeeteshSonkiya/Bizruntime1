using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void del(string text);
    class Delegates_Event3
    {
        public static event del myEvent;
        public static void print(string text)
        {
            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
            del obj = print;
            obj("hello Delegate...");
            Console.WriteLine();

            myEvent += print;
            myEvent("Hello MyEvent.....");
            Console.Read();
        }
    }
}
