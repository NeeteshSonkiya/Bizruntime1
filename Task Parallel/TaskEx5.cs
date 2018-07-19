using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallel
{
    class TaskEx5
    {
        public static void ParallelInvocation()
        {
            Parallel.Invoke(() => DoWork(), () => DoWork1(), () => DoWork2());
        }
        public static void DoWork()
        {
            Console.WriteLine("Do Some Work.....");
        }
        public static void DoWork1()
        {
            Console.WriteLine("Do Some Extra Work.....");
        }
        public static void DoWork2()
        {
            Console.WriteLine("Do Some Extra Work for extra profit.....");
        }
        static void Main(string[] args)
        {
            ParallelInvocation();
            Console.ReadKey();
        }
    }
}
