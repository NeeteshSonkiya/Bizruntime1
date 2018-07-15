using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate string myDel(string str);
    class Delegates_Event1
    {
        event myDel myEvent;

        public Delegates_Event1()
        {
            this.myEvent += new myDel(WelcomeUser);
        }
        public static string WelcomeUser(string user)
        {
            return "Hello " + user;
        }
        static void Main(string[] args)
        {
            Delegates_Event1 de = new Delegates_Event1();
            string result = de.myEvent("Mitsian");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
