using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class AsyncAwait9
    {
        static void Main()
        {
            var demo = new AsyncAwaitDemo();
            demo.DoStuff();
            int i = 0;
            while (i < 10) 
            {
                Console.WriteLine("Doing Stuff on the Main Thread....");
                i++;
            }
            Console.Read();
        }
    }

    public class AsyncAwaitDemo
    {
        public async Task DoStuff()
        {
            await LongRunningOperation();
        }

        private static async Task<string> LongRunningOperation()
        {
            int counter;

            for (counter = 0; counter < 15; counter++)
            {
                Console.WriteLine(".");
            }
            Console.WriteLine(counter);
            Console.WriteLine();
            return "Counter = " + counter;
        }
    }
}
