using System;
using System.Collections.Generic;
using System.Text;

namespace Abtstraction
{
    abstract class Animal
    {
        public abstract void eat();
        public virtual void speak()
        {
            Console.WriteLine("animal can speak ");
        }
    }
    class Dog : Animal
    {
        public override void eat()      //Mandatory
        {
            Console.WriteLine("Dog can eat ");
        }
        public override void speak()       //Optional
        {
            Console.WriteLine("dog can speak ");
        }
    }
    class Test2
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            Animal a1 = new Dog();
            d1.eat();
            d1.speak();
            Console.WriteLine();
            a1.eat();
            a1.speak();
            Console.Read();
        }
    }
}
