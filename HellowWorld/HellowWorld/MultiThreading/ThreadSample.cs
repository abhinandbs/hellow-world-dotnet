using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.MultiThreading
{
    public static class ThreadSample
    {
        private static ThreadLocal<int> _threadLocalValue = new ThreadLocal<int>(() => Thread.CurrentThread.ManagedThreadId);
        public static void Main()
        {
            Thread thread = new Thread(()=>DoWork("nandu"));;
            Thread thread2 = new Thread(()=>DoWork2("abhi"));;

            thread.Start();
            thread2.Start();

            Console.WriteLine("Called after start");

          
            // Wait for the worker thread to finish
            thread.Join(100);

            Console.WriteLine("COMPLETED");

            Task task = new Task(()=>DoWork("car"));
            task.Start();

            // Queue a method for execution on a thread pool thread

            ThreadPool.QueueUserWorkItem((state) =>
            {
                Console.WriteLine("ThreadPool thread executing...");
                Thread.Sleep(2000); // Simulating work
                Console.WriteLine("ThreadPool thread finished.");
            });


        }
        public static void DoWork(string name)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker thread: " + i+name);
                Thread.Sleep(1000); // Sleep for 100 milliseconds
            }
        }
        public static void DoWork2(string name)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main thread: " + i);
                Thread.Sleep(100); // Sleep for 100 milliseconds
            }

        }

    }
}
