using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class DelegateDemo
    {
        public delegate void Procedure();

        public static void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3");
        }

        static void Main()
        {
            Procedure someProcs = null;

            someProcs += new Procedure(DelegateDemo.Method1);
            someProcs += new Procedure(Method2);  

            DelegateDemo demo = new DelegateDemo();

            someProcs += new Procedure(demo.Method3);
            someProcs();
        }

    }
}

