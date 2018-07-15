using System;

namespace Arrays
{
    class ArrayDeclaration
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];          //array is fixed size
            string[] s = new string[11];
            double[] d;
            d = new double[15];
            char[] c = new char[] { 'h', 'e', 'l', 'l','o' };
            x[0] = 10;
            x[1] = 20;
            x[2] = 30;
            s[4] = "hello";
            s[6] = "welcome";
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + ",");
            }
            Console.WriteLine();
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + ",");
            }
            Console.WriteLine();
            foreach(char c1 in c)
            {
                Console.Write(c1 + "");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
