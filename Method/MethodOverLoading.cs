using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MethodOverLoading
    {
        void test1()
        {
            Console.WriteLine("test1 method...........");
        }
        void test1(int i)
        {
            Console.WriteLine("test1 method with args(int i)");
        }
        void test1(int i , string s)
        {
            Console.WriteLine("test1 method with args(int i, string s)");
        }
        static void Main(string[] args)
        {
            MethodOverLoading m1 = new MethodOverLoading();
            m1.test1();
            m1.test1(10);
            m1.test1(10, "hello");
            Console.Read();
        }
    }
}
