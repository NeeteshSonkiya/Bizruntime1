using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx26
    {
        static void Main(string[] args)
        {
           var fileLines = Observable.Create<string>(
            o =>
            {
                var dScheduler = DispatcherScheduler.Instance;
                var lines = File.ReadAllLines(@"F:\Bizruntime\Workspace\File IO\f1.txt");
                foreach (var line in lines)
                {
                    var localLine = line;
                    dScheduler.Schedule(
                    () => o.OnNext(localLine));
                }
                return Disposable.Empty;
            });
            
            Console.ReadKey();
        }
    }
}