using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4       //Constructor overloading
{
    class ConstructorOveerloading
    {
        public ConstructorOveerloading()
        {
            Console.WriteLine("no arg constructor");
        }
        public ConstructorOveerloading(int a, int b)
            :this()
        {
            Console.WriteLine("Parameterized constructor");
        }
        public ConstructorOveerloading(int a, float b, double c, string s)
            :this (10, 20)
        {
            Console.WriteLine("Parameterized constructor 2nd");
        }
        static void Main(string[] args)
        {
            ConstructorOveerloading c = new ConstructorOveerloading();
            ConstructorOveerloading c1 = new ConstructorOveerloading(21, 21.2f, 321.2, "Welcome");
            Console.ReadKey();
        }
    }
}
