using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallel
{
    class TaskEx7
    {
        static void CreateTasks()
        {
            Console.WriteLine();
            Action<object> action = (object obj) =>
            {
                Console.WriteLine("Task = {0}, obj = {1}", Task.CurrentId, obj, Thread.CurrentThread.ManagedThreadId);
            };

            //Creating a Task
            Task task1 = new Task(action, "alpha");

            //Construct a started task
            Task task2 = Task.Factory.StartNew(action, "beta");

            //Launch Task1
            task1.Start();
            Console.WriteLine("Task has been launched. (Main Thread = {0})", Thread.CurrentThread.ManagedThreadId);

            //wait for the task to finish
            task1.Wait();

            //Construct a started task using Task.run
            string taskData = "delta";
            Task task3 = Task.Run(() =>
            {
                Console.WriteLine("Task = {0}, obj = {1}, Thread = {2}", Task.CurrentId, taskData, Thread.CurrentThread.ManagedThreadId);
            });

            //wait for the task to finish
            task3.Wait();

            //Construct an unstarted task
            Task task4 = new Task(action, "gamma");

            //Run it synchronously
            task4.RunSynchronously();

            //to wait for it the event exceptions were thrown by task
            task4.Wait();
        }
        static void Main(string[] args)
        {
            CreateTasks();
            Console.Read();
        }
    }
}
