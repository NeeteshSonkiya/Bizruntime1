using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using log4net;

namespace TaskParallel
{
    class TaskEx10
    {
        static void Main(string[] args)
        {
            Add(10, 20);
            Mul(10, 2);
            Console.ReadKey();
        }
        public static async Task Add(int a, int b)
        {
            Console.WriteLine(a + b);
            Sub(a, b);
            Console.WriteLine("From add method");
        }
        static void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        static int Mul(int a, int b)
        {
            Console.WriteLine(a*b);
            a = a * b;
            return a;
        }
    }
}
