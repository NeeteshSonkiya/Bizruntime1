using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AsyncAndAwait
{
    class AsyncAwait8
    {
        static string filePath = @"F:\Bizruntime\Workspace\Asynch and Await\f2.txt";
        static void Main()
        {
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();
        }

        static async void CallMethod()
        {
          //  string filePath = @"F:\Bizruntime\Workspace\Asynch and Await\f2.txt";
            

            Console.WriteLine(" Other Work 1");
            Console.WriteLine(" Other Work 2");
            Console.WriteLine(" Other Work 3");

            Task<int> task = ReadFile(filePath);
            int length = await task;

            Console.WriteLine(" Total length: " + length);

            Console.WriteLine(" After work 1");
            Console.WriteLine(" After work 2");
        }

        static async Task<int> WriteFile(string file)
        {
            int length = 0;

            Console.WriteLine(" File Writing is starting......");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string str = Console.ReadLine();
                writer.WriteAsync(str);
                Console.WriteLine();
                length = str.Length;
            }
            Console.WriteLine(" File Writing is completed");
            Console.WriteLine();
            return length;
        }
        static async Task<int> ReadFile(string file)
        {
            int length = 0;
            Task<int> task = WriteFile(filePath);
            Console.WriteLine(" File reading is starting......");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string str = await reader.ReadToEndAsync();
                Console.WriteLine(str);
                Console.WriteLine();
                length = str.Length;
            }
            Console.WriteLine(" File reading is completed");
            return length;
        }
    }
}
