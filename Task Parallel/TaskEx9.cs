using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallel
{
    class TaskEx9
    {
        static void CancelToken()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = new Task(() =>
            {
                for (int i = 1; i <= 10000000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Cancel() called");
                        return;
                    }
                    Console.WriteLine("Loop value is {0}", i);
                }
            }, token);

            Console.WriteLine("Press any key to start Task");
            Console.ReadKey();

            task.Start();

            Console.WriteLine("Press any key to cancel the task");
            Console.ReadKey();

            Console.WriteLine("Cancelling the Task.....");
            cancellationTokenSource.Cancel();

            Console.WriteLine("Main Method is completed. Press any key to exit ");
            Console.Read();
        }
        static void Main(string[] args)
        {
            CancelToken();
        }
    }
}
