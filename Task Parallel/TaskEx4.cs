using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallel
{
    class TaskEx4
    {
        //MostDirective way
        #region MostDirective way
        public static void MostDirective()
        {
            Task.Factory.StartNew(() => {
                Console.WriteLine("We are using MostDirective Way");
                Thread.Sleep(4000);
                Console.WriteLine("We are using MostDirective Way");

            });
        }
        #endregion
        //Task with Action
        #region Task with Action
        public static void PrintMessage()
        {
            Console.WriteLine("PrintMessage...");
            Thread.Sleep(3500);
            Console.WriteLine("PrintMessage...");
        }
        public static void ThreadUsingAction()
        {
            Task task = new Task(new Action(PrintMessage));
            task.Start();

        }
        #endregion
        //Task using Delegates
        #region using delegate
        public static void UsingDelegate()
        {
            Task task = new Task(delegate { PrintDelegateMessage(); });
            task.Start();
        }
        public static void PrintDelegateMessage()
        {
            Console.WriteLine("PrintDelegateMessage......");
            Thread.Sleep(3000);
            Console.WriteLine("PrintDelegateMessage......");
        }
        #endregion

        //Task using lambda
        #region Lambda
        public static void LambdaExpression()
        {
            Task task = new Task(() => PrintLambdaMessage());
            task.Start();
        }
        public static void PrintLambdaMessage()
        {
            Console.WriteLine("PrintLambdaMessage....");
            Thread.Sleep(2500);
            Console.WriteLine("PrintLambdaMessage....");
        }
        #endregion
        //Task using Anonymous
        #region
        public static void AnonymousMethod()
        {
            Task task = new Task(() => {
                Console.WriteLine("from Anonymous Method...");
                Thread.Sleep(2000);
                Console.WriteLine("from Anonymous Method...");
            });
            task.Start();
        }
        #endregion
        static void Main(string[] args)
        {
            MostDirective();
            ThreadUsingAction();
            UsingDelegate();
            LambdaExpression();
            AnonymousMethod();
            Console.ReadKey();
        }
    }
}
