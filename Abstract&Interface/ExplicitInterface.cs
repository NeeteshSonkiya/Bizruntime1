using System;
using System.Collections.Generic;
using System.Text;

namespace Abtstraction
{
    interface I1
    {
        void interfaceMethod();
    }
    interface I2
    {
        void interfaceMethod();
    }
    class ExplicitInterface : I1, I2
    {
        void I1.interfaceMethod()
        {
            Console.WriteLine("I1 interface method....");
        }
        void I2.interfaceMethod()
        {
            Console.WriteLine("I2 interface method....");
        }
        static void Main(string[] args)
        {
            ExplicitInterface eI = new ExplicitInterface();
            ((I1)eI).interfaceMethod();
            Console.WriteLine();
            ((I2)eI).interfaceMethod();
            Console.Read();
        }
    }
}
