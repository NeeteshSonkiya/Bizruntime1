using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Animal eating.... ");
        }
    }
    public class Dog:Animal
    {
        public override void eat()
        {
            Console.WriteLine("Dog eating....");
        }
    }
    class MethodOverriding
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
            Console.ReadKey();
        }
    }
}
