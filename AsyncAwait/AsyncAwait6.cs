using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAndAwait
{
    class AsyncAwait6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting..");
            var worker = new Worker();
            worker.DoWork();

            while (!Worker.IsComplete)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine("Done");
            Console.Read();
        }
    }
    class Worker
    {
        public static bool IsComplete { get; set; }
        public async Task DoWork()
        {
            IsComplete = false;
            Console.WriteLine("Doing work");
            await LongOperation();
            Console.WriteLine("Work Completed");
            IsComplete = true;
        }
        public async Task LongOperation()
        {
            Console.WriteLine("Working");
            Thread.Sleep(2000);
            await Task.CompletedTask;
            Console.WriteLine("Operation Done");
        }
    }
}
