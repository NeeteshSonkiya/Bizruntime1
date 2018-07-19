using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallel
{
    class TaskEx6
    {
        static void Main(string[] args)
        {
            //Thread t1 = new Thread(RunMillionTimeIteration);
            //t1.Start();
            Parallel.For(0, 10000000, x => RunMillionTimeIteration());
            Console.Read();
        }
        public static void RunMillionTimeIteration()
        {
            string x = "";
            for (int iIndex = 0; iIndex < 10000000; iIndex++)
            {
                x = x + "s";
            }
        }
    }
}
