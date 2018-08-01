using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx25
    {
        static void Main(string[] args)
        {
            var myName = "Lee";
            Scheduler.NewThread.Schedule(
            () => Console.WriteLine("myName = {0}", myName));
            Console.ReadKey();
        }
    }
}
