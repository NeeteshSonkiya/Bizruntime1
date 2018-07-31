using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx20
    {
        static void ForEach()
        {
            var source = Observable.Interval(TimeSpan.FromSeconds(1))
                 .Take(5);
            source.ForEach(i => Console.WriteLine("received {0} @ {1}", i, DateTime.Now));
            Console.WriteLine("completed @ {0}", DateTime.Now);
        }
        static void Subscribed()
        {
            var source = Observable.Interval(TimeSpan.FromSeconds(1))
                .Take(5);
            source.Subscribe(i => Console.WriteLine("received {0} @ {1}", i, DateTime.Now));
            Console.WriteLine("completed @ {0}", DateTime.Now);
        }
        static void Main(string[] args)
        {
            ForEach();
            Console.WriteLine(".......................");
            Subscribed();
            Console.ReadKey();
        }
    }
}
