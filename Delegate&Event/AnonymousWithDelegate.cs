using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int calculation(int a, int b);
    class AnonymousWithDelegate
    {
        public static void display()
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multipication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Enter option....");
        }
        static void Main(string[] args)
        {
            calculation cal = delegate (int a, int b)
            {
                display();
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                    return a + b;
                else if (n == 2)
                    return a - b;
                else if (n == 3)
                    return a * b;
                else if (n == 4)
                    return a / b;
                else
                    Console.WriteLine("Enter valid option");
                return 0;
            };
            int result = cal(10, 10);
            Console.WriteLine("The result is : " + result);
            Console.Read();
        }
    }
}
