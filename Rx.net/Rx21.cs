using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx21
    {
        static void ToEnumerableExample()
        {
            var period = TimeSpan.FromMilliseconds(200);
            var source = Observable.Timer(TimeSpan.Zero, period)
            .Take(5);
            var result = source.ToEnumerable();
            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("done");
        }
        static void Main(string[] args)
        {
            ToEnumerableExample();
            Console.ReadKey();
        }
    }
}
