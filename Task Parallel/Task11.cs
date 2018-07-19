
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class Task11
    {
            static void Main(string[] args)
            {
                Task t1 = Task.Factory.StartNew(() => work1(1, 3000));
                Task t2 = Task.Factory.StartNew(() => work1(2, 2000));
                Task t3 = Task.Factory.StartNew(() => work1(3, 1000));

                var tasklist = new List<Task> { t1, t2, t3 };
                Task.WaitAll(tasklist.ToArray());

                Console.WriteLine("press any key to exit");
                Console.ReadKey();
            }
            public static void work1(int id, int sleep)
            {
                Console.WriteLine("TaskFactory {0} start", id);
                Thread.Sleep(sleep);
                Console.WriteLine("TaskFactory {0} completed", id);
            }
        }
    }