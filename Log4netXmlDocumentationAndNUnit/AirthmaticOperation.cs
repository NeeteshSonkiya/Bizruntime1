using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netAndNunitTest
{
    class AirthmaticOperation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number\n");
            int num1, num2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            MathsHelper helper = new MathsHelper();
            int x = helper.add(num1, num2);
            Console.WriteLine("\n The sum of " + num1 + " and " + num2 + " is " + x);
            int y = helper.sub(num1, num2);
            Console.WriteLine("\n The differance between " + num1 + " and " + num2 + " is " + y);
            Console.ReadKey();
            
        }
    }
    public class MathsHelper
    {
        public int add(int a, int b)
        {
            int x = a + b;
            return x;
        }
        public int sub(int a, int b)
        {
            int x = a - b;
            return x;
        }
    }
}
