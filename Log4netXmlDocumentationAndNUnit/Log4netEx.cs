using System;
using System.IO;
using log4net.Config;
namespace log4netAndNunitTest
{
    
    class Log4netEx
    {

        int i;

        int j;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Log4netEx));
      
        public int Divide(int i, int j)
        {
            int c = 0;
            BasicConfigurator.Configure();
            try
            {
                if (j == 0)
                    throw new DivideByZeroException("Value should be grater than zero");
                c = i / j;
                return c;
            }
            catch (DivideByZeroException ex)
            {
                log.Error(ex.Message);
                return c;
            }

        }

  
        public void GetData()
        {
            BasicConfigurator.Configure();
            x:
            try
            {
                Console.Write("Enter First Number : ");
                i = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                log.Error(ex.Message); goto x;
            }

            y:
            try
            {
                Console.Write("Enter Second Number : ");
                j = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                log.Error(ex.Message); goto y;
            }

        }

    
        static void Main(string[] args)
        {
            Log4netEx l = new Log4netEx();
            l.GetData();
            int k = l.Divide(l.i, l.j);
            Console.Write("Result : " + k);
            Console.ReadKey();
        }
    }
}
