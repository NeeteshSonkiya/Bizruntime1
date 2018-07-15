using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Collection
{
    class BitArrayEx
    {
        public static void operation()
        {
            BitArray b1 = new BitArray(8);
            BitArray b2 = new BitArray(8);
            Console.WriteLine("Print b1 array...");
            Console.WriteLine();
            display(b1);
            Console.WriteLine("---------------------");
            Console.WriteLine("Print b2 array...");
            Console.WriteLine();
            display(b2);
            Console.WriteLine("----------------------");
            BitArray b3 = new BitArray(8);
            b3 = b1.And(b2);
            Console.WriteLine("Performing AND operation bw b1 & b2 ...");
            display(b3);
            Console.WriteLine("--------------------------");
            b3 = b1.Or(b2);
            Console.WriteLine("Performing OR operation bw b1 & b2 ...");
            display(b3);
            Console.WriteLine("--------------------------");
            b3 = b1.RightShift(4);
            Console.WriteLine("Performing RIGHT SHIFT operation on b1 ...");
            display(b3);
            Console.WriteLine("--------------------------");
            b3 = b1.Not();
            Console.WriteLine("Performing Not operation on b1 ...");
            display(b3);
            Console.WriteLine("--------------------------");
        }
        public static void display(BitArray ba)
        {
            foreach (bool b in ba)
            {
                Console.Write(b + "  ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            operation();
            Console.Read();
        }
    }
}
