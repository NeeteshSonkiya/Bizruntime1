using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class GenericsDelegates
    {
        public static double addNums1(int x, float y, double z)
        {
            return x + y + z;
        }
        public static void addNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool checkLength(string str)
        {
            if (str.Length >= 5)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = addNums1;
            double result = obj1(10, 10.1f, 12.212);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = addNums2;
            obj2(10, 10.1f, 12.121);

            Predicate<string> obj3 = checkLength;
            bool flag = obj3("hello jay");

            Console.WriteLine(flag);
            Console.Read();
        }
    }
}
