using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{

    abstract class Animal
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("Animal sound....");
        }
    }
    class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("dog eating...");
        }
    }

    class Abstraction
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Animal a = d;
            a.eat();
            d.sound();
            Console.ReadKey();
        }
    }
}
