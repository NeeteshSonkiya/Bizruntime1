using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4       //Constructor & destructor
{
    class ConstructorDestructorEx
    {
        public ConstructorDestructorEx()
        {
            Console.WriteLine("Constructor  invoked");
        }
        public ConstructorDestructorEx(int i)
            : this()
        {
            Console.WriteLine("value of i= " + i);
        }
        ~ConstructorDestructorEx()
        {
            Console.WriteLine("Destructor invoked");
        }
        static void Main(string[] args)
        {
            ConstructorDestructorEx c1 = new ConstructorDestructorEx();
            ConstructorDestructorEx c2 = new ConstructorDestructorEx(10);
            
            Console.ReadKey();
        }
    }
}
