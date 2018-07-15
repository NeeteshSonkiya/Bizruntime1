using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class ParamsKeyword
    {
        public void display(params int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + ", ");
            }
            Console.WriteLine();
        }
        public void display1(params object[] x1)
        {
            for (int i = 0; i < x1.Length; i++)
            {
                Console.Write(x1[i] + ", ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ParamsKeyword pk = new ParamsKeyword();
            pk.display(1, 23, 2, 32, 3, 323, 2, 32, 3);
            pk.display1(1, 23, 2323.2, "dsfsf", "f", 'w', 's', 3213, 3.2f);
            Console.Read();
        }
    }
}
