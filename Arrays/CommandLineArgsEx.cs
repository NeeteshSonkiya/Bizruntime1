using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class CommandLineArgsEx
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arguments length : " + args.Length);
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
