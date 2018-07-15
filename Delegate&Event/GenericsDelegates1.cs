using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public  delegate T add<T>(T a, T b);

    class GenericsDelegates1
    {
        public static int add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public static string concate(string str1, string str2)
        {
            string result = str1 + str2;
            return result;
        }
        static void Main(string[] args)
        {
            add<int> del = add;
            add<string> obj = concate;
            
            Console.WriteLine(del(10, 20));
            Console.WriteLine(obj("hello guys ", " Welcome to Bangalore"));
            Console.Read();
         }
    }
}
