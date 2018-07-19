using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallel
{
    class TaskEx2
    {
        public static void TaskReturningResult()
        {
            var t = Task<int>.Run(() =>
            {
                // Just loop.  
                int max = 1000000;
                int value = 0;
                for (value = 0; value <= max; value++)
                {
                    if (value == max / 2 && DateTime.Now.Hour <= 12)
                    {
                        value++;
                        break;
                    }
                }
                return value;
            });
            Console.WriteLine("Finished {0:N0}.", t.Result);
        }
        static void Main(string[] args)
        {
            TaskReturningResult();
            Console.ReadKey();
        }
    }
}
