using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace AsyncAndAwait
{
    class AsyncAwait2
    {
        static void Main(string[] args)
        {
            Thread t1 = Thread.CurrentThread;
            t1.Name = "main";
            Task t = new Task(test);
            t.Start();
            t.Wait();
            Console.WriteLine("After task " + t1.Name);
            Console.Read();
        }
        public static void test()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "child";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Test " + i + t.Name);
            }
        }
    }
}
