using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netAndNunitTest
{
    class Square
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number\n");
            int num = int.Parse(Console.ReadLine());
           
            MathHelper helper = new MathHelper();
            int x = helper.square(num);
            Console.WriteLine("\n The square of " + num + " is " + x);
            
            Console.ReadKey();
        }
    }
    public class MathHelper
    {
        public int square(int a)
        {
            int x = a * a;
            return x;
        }
    }
}
