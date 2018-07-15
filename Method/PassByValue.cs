using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PassByValue
    {
        public void method(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("result = " + result);
        }
        public string method1(string name, int age)
        {
            Console.WriteLine("name is : " + name);
            Console.WriteLine("age is : " + age);
            return name;
        }
        static void Main(string[] args)
        {
            PassByValue cbv = new PassByValue();
            cbv.method(10, 40);
            cbv.method1("Naman", 22);
            Console.WriteLine("Main method complete");
            Console.Read();
        }
    }
}
