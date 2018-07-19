using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallel
{
    class TaskEx3
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() => Console.WriteLine("hello from task"));
            Console.WriteLine("before creating and running the task");
            t.Wait();
            Console.WriteLine("after the task");
            Console.ReadKey();
        }
    }
}
