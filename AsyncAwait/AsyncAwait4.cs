using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AsyncAndAwait
{
    class AsyncAwait4
    {
        static void Main()
        {
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();
        }

        static async void CallMethod()
        {
            string filePath = @"F:\Bizruntime\Workspace\Asynch and Await\f2.txt";
            Task<int> task = ReadFile(filePath);

            Console.WriteLine(" Other Work 1");
            Console.WriteLine(" Other Work 2");
            Console.WriteLine(" Other Work 3");

            int length = await task;
            Console.WriteLine(" Total length: " + length);

            Console.WriteLine(" After work 1");
            Console.WriteLine(" After work 2");
        }

        static async Task<int> ReadFile(string file)
        {
            int length = 0;

            Console.WriteLine(" File reading is starting......");
            using (StreamReader reader = new StreamReader(@"F:\Bizruntime\Workspace\Asynch and Await\f2.txt"))
            {
                string s = await reader.ReadToEndAsync();
                Console.WriteLine(s);
                Console.WriteLine();
                length = s.Length;
            }
            Console.WriteLine(" File reading is completed");
            return length;
        }
    }
}
