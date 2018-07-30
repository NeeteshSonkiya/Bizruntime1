using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx16
    {

        static void DefaultIfEmptyExmaple()
        {
            var subject = new Subject<int>();
            subject.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("Subject completed"));
            var defaultIfEmpty = subject.DefaultIfEmpty();
            defaultIfEmpty.Subscribe(
            b => Console.WriteLine("defaultIfEmpty value: {0}", b),
            () => Console.WriteLine("defaultIfEmpty completed"));
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnCompleted();
        }

        static void ElementAtExmaple()
        {
            var subject = new Subject<int>();
            subject.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("Subject completed"));
            var elementAt1 = subject.ElementAt(1);
            elementAt1.Subscribe(
            b => Console.WriteLine("elementAt1 value: {0}", b),
            () => Console.WriteLine("elementAt1 completed"));
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnCompleted();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n----------DefaultIfEmpty---------");
            DefaultIfEmptyExmaple();
            Console.WriteLine("\n----------ElementAt--------------");
            ElementAtExmaple();
            Console.ReadKey();
        }
    }
}
