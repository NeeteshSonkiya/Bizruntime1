using System;
using System.IO;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class AsyncAwait3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Main ");
            test1();
            Console.WriteLine("End Main ");
            Console.Read();
        }
        static async Task test1()
        {
            Console.WriteLine("Start test1 ");
            await test2();
            Console.WriteLine("End test1 ");
        }
        static async Task test2()
        {
            Console.WriteLine("Start test2 ");
            await test3();
            Console.WriteLine("End test2 ");
        }
        static async Task test3()
        {
            Console.WriteLine("Start test3 ");
            await Task.CompletedTask;
            Console.WriteLine("End test3 ");
        }
    }
}