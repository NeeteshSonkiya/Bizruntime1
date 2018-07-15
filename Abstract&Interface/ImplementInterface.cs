using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Abtstraction
{
    interface IAnimal
    {
        void eat();
        void speak();
    }
    class Lion : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("Lion is eating...");
        }
        public void speak()
        {
            Console.WriteLine("Lion is speaking...");
        }
    }
    class Tiger : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("Tiger is eating...");
        }
        public void speak()
        {
            Console.WriteLine("Tiger is speaking....");
        }
    }
    class ImplementInterface
    {
        static void Main(string[] args)
        {
            IAnimal a1;
            a1 = new Lion();
            a1.eat();
            a1.speak();
            Console.WriteLine("..........................");
            a1 = new Tiger();
            a1.eat();
            a1.speak();
            Console.ReadLine();  
        }
    }
}
