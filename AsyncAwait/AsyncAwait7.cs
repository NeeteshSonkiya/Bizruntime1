using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class AsyncAwait7
    {
        public async Task add(int a, int b)
        {
            await sub(a, b);
            int result = a + b;
            Console.WriteLine("The addition is : " + result);
        }
        public async Task sub(int a, int b)
        {
            await mul(a, b);
            int result = a - b;
            Console.WriteLine("The subtraction is : " + result);
        }
        public async Task mul(int a, int b)
        {
            await div(a, b);
            int result = a * b;
            Console.WriteLine("The Multipication is : " + result);
        }
        public async Task div(int a, int b)
        {
            await Task.CompletedTask;
            int result = a / b;
            Console.WriteLine("The Division is : " + result);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st number : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd number : ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            AsyncAwait7 aa = new AsyncAwait7();
            aa.add(x, y);
            Console.Read();
        }
    }
}
