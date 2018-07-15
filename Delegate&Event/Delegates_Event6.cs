using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    //Publisher
    public class Publisher
    {
        public delegate void dg_OddNumber();
        public event dg_OddNumber ev_OddNumber;

        public void Add()
        {
            Console.WriteLine("Enter Two number...");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = a + b;
            Console.WriteLine("The result is : " + result);
            if ((result % 2 != 0) && (ev_OddNumber != null))
            {
                ev_OddNumber();
            }

        }
    }
    //Subcriber 
    class Delegates_Event6
    {

        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            pub.ev_OddNumber += new Publisher.dg_OddNumber(EventMessage);
            pub.Add();
            Console.Read();
        }
        static void EventMessage()
        {
            Console.WriteLine("----*--=Event Executed=--*--- The Result is Oddnumber--*--");
        }
    }
}
