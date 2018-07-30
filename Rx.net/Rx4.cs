using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx4
    {
        static void WriteSequenceToconsole(IObservable<string> sequence)
        {
            sequence.Subscribe(value => Console.WriteLine(value));
        }
        static void ReplaySubject(ReplaySubject<string> subject)
        {
            subject.OnNext("Welcome");
            WriteSequenceToconsole(subject);
            subject.OnNext("To");
            subject.OnNext("Jaurasic kingdom");
        }
        static void Main(string[] args)
        {
            var subject = new ReplaySubject<string>();
            ReplaySubject(subject);
            Console.ReadKey();
        }
    }
}
