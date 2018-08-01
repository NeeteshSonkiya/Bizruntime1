using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx27
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Scheduler Example..........");
            TestSchedulerEx();
            Console.WriteLine();
            Console.WriteLine("Start scheduler example..............");
            startEx();
            Console.WriteLine();
            Console.WriteLine("stop scheduler example...............");
            stopEx();
            Console.WriteLine();
            Console.ReadKey();

        }
        static void TestSchedulerEx()
        {
            var scheduler = new TestScheduler();
            scheduler.Schedule(() => Console.WriteLine("A")); //Schedule immediately
            scheduler.Schedule(TimeSpan.FromTicks(10), () => Console.WriteLine("B"));
            scheduler.Schedule(TimeSpan.FromTicks(20), () => Console.WriteLine("C"));
            Console.WriteLine("scheduler.AdvanceTo(1);");
            scheduler.AdvanceTo(1);
            Console.WriteLine("scheduler.AdvanceTo(10);");
            scheduler.AdvanceTo(10);
            Console.WriteLine("scheduler.AdvanceTo(15);");
            scheduler.AdvanceTo(15);
            Console.WriteLine("scheduler.AdvanceTo(20);");
            scheduler.AdvanceTo(20);
        }
        static void startEx()
        {
            var scheduler = new TestScheduler();
            scheduler.Schedule(() => Console.WriteLine("A")); //Schedule immediately
            scheduler.Schedule(TimeSpan.FromTicks(10), () => Console.WriteLine("B"));
            scheduler.Schedule(TimeSpan.FromTicks(20), () => Console.WriteLine("C"));
            Console.WriteLine("scheduler.Start();");
            scheduler.Start();
            Console.WriteLine("scheduler.Clock:{0}", scheduler.Clock);
        }
        static void stopEx()
        {
            var scheduler = new TestScheduler();
            scheduler.Schedule(() => Console.WriteLine("A"));
            scheduler.Schedule(TimeSpan.FromTicks(10), () => Console.WriteLine("B"));
            scheduler.Schedule(TimeSpan.FromTicks(15), scheduler.Stop);
            scheduler.Schedule(TimeSpan.FromTicks(20), () => Console.WriteLine("C"));
            Console.WriteLine("scheduler.Start();");
            scheduler.Start();
            Console.WriteLine("scheduler.Clock:{0}", scheduler.Clock);
        }
        static void scheduleCollisionEx()
        {
            var scheduler = new TestScheduler();
            scheduler.Schedule(TimeSpan.FromTicks(10), () => Console.WriteLine("A"));
            scheduler.Schedule(TimeSpan.FromTicks(10), () => Console.WriteLine("B"));
            scheduler.Schedule(TimeSpan.FromTicks(10), () => Console.WriteLine("C"));
            Console.WriteLine("scheduler.Start();");
            scheduler.Start();
            Console.WriteLine("scheduler.Clock:{0}", scheduler.Clock);
        }
    }
}
