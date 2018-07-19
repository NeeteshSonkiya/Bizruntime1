using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallel
{
    class TaskEx1
    {
        public static void TasksWithWait()
        {
            Thread.CurrentThread.Name = "Main Thread";
            Task taskA = new Task(() => Console.WriteLine("Hello Task Library"));
            taskA.Start();
            Console.WriteLine("Hello from thread {0}",Thread.CurrentThread.Name);
            taskA.Wait();
        }
        static void Main(string[] args)
        {
            TasksWithWait();
            Console.ReadKey();
        }
    }
}
