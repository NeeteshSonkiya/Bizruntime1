using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting on threadId:{0}", Thread.CurrentThread.ManagedThreadId);
            var subject = new Subject<object>();
            subject.Subscribe(
            o => Console.WriteLine("Received {1} on threadId:{0}",
            Thread.CurrentThread.ManagedThreadId,
            o));
            ParameterizedThreadStart notify = obj =>
            {
                Console.WriteLine("OnNext({1}) on threadId:{0}",
                Thread.CurrentThread.ManagedThreadId,
                obj);
                subject.OnNext(obj);
            };
            notify(1);
            new Thread(notify).Start(2);
            new Thread(notify).Start(3);
            Console.ReadKey();
        }
    }
}
