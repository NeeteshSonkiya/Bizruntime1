using System;
using System.Collections.Generic;
using System.Text;

namespace First   //namespace
{
    class Hello
    {
        public void hello()
        {
            Console.WriteLine("say hello first");
        }
    }
}
namespace Second
{
    class Hello
    {
        public void hello()
        {
            Console.WriteLine("say Hello second");
        }
    }
}
    public class NamespaceEx
    {
        static void Main(string[] args)
        {
            First.Hello h1 = new First.Hello();
            Second.Hello h2 = new Second.Hello();
            h1.hello();
            h2.hello();
            Console.ReadKey();
        }
    }
