using System;

namespace ConsoleApp1       // Parameterized and non parameterized method
{
    class Method1
    {
        public void method1()
        {
            Console.WriteLine(" This is non parameterized method ");
        }
        public void method2(int a, int b)
        {
            Console.WriteLine(" This is parameterized method");
        }
   
        static void Main(string[] args)
        {
            Method1 m = new Method1();
            m.method1();
            m.method2(10, 20);
            Console.ReadKey();
        }
    }
}
