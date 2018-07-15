using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4       //parameterized constructor
{
    class ConstructorEx
    {
        ConstructorEx(int id, string name, float salary)
        {
            Console.WriteLine("{0} . {1} {2}", id, name, salary);
        }
        static void Main(String[] args)
        {
            ConstructorEx c1 = new ConstructorEx(1, "Lucifer", 30004.23f);
            ConstructorEx c2 = new ConstructorEx(2, "Dean", 24003.32f);
            ConstructorEx c3 = new ConstructorEx(3, "Jess", 43002.54f);
            Console.ReadKey();
        }
    }
}
