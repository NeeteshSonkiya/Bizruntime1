using System;

namespace Abtstraction
{
    abstract class AbsParent
    {
        public virtual int add(int x , int y)
        {
            return x + y;
        }
        public virtual int sub(int x, int y)
        {
            return x - y;
        }
    }
    class AbsChild : AbsParent
    {
        public override int add(int x, int y)
        {
            return x + y;
        }
        public override int sub(int x, int y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            AbsChild ac = new AbsChild();
            int result = ac.add(a, b);
            result = ac.sub(a, b);
            Console.WriteLine("The result is : " + result);
            Console.Read();
        }
    }
}
