using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace TaskParallel
{
    class TaskEx8
    {
        static void Main(string[] args)
        {
            String[] colors = new string[] { "1.Blue", "2.Black", "3.Red", "4.Green", "5.Yellow", "6.White", "7.Brown", "8.Pink", "9.Violate", "10.Orange" };

            //using Parallel Foreach
            var sw = Stopwatch.StartNew();

            Parallel.ForEach(colors, color =>
            {
                Console.WriteLine("color = {0},     Thread Id = {1}", color, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });
            Console.WriteLine("Parallel Foreach execution time {0}", sw.Elapsed.TotalSeconds);
            Console.WriteLine("\nTraditional Foreach");
            // using foreach loop
            foreach (string color in colors)
            {
                Console.WriteLine("color = {0},     Thread Id = {1}", color, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
            Console.WriteLine("Tradintional Foreach Execution Time {0}", sw.Elapsed.TotalSeconds);
            Console.Read();
        }
    }
}
