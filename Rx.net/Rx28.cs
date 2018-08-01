using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{

    class Rx28
    {

        static void ColdObservableExample()
        {
            var scheduler = new TestScheduler();
            var source = scheduler.CreateColdObservable(
            new Recorded<Notification<long>>(10000000, Notification.CreateOnNext(0L)),
            new Recorded<Notification<long>>(20000000, Notification.CreateOnNext(1L)),
            new Recorded<Notification<long>>(30000000, Notification.CreateOnNext(2L)),
            new Recorded<Notification<long>>(40000000, Notification.CreateOnNext(3L)),
            new Recorded<Notification<long>>(40000000, Notification.CreateOnCompleted<long>())
            );
            var testObserver = scheduler.Start(
            () => source,
            0,
            0,
            TimeSpan.FromSeconds(5).Ticks);
            Console.WriteLine("Time is {0} ticks", scheduler.Clock);
            Console.WriteLine("Received {0} notifications", testObserver.Messages.Count);
            foreach (Recorded<Notification<long>> message in testObserver.Messages)
            {
                Console.WriteLine("  {0} @ {1}", message.Value, message.Time);
            }

        }
        static void HotObservableExample()
        {
            var windowIdx = 0;
            var source = Observable.Interval(TimeSpan.FromSeconds(1)).Take(10);
            source.Window(3)
            .Subscribe(window =>
            {
                var id = windowIdx++;
                Console.WriteLine("--Starting new window");
                var windowName = "Window" + this.WindowIdx;
                window.Subscribe(
    value => Console.WriteLine("{0} : {1}", windowName, value),
    ex => Console.WriteLine("{0} : {1}", windowName, ex),
    () => Console.WriteLine("{0} Completed", windowName));
            },
            () => Console.WriteLine("Completed"));
        }
    }
}
