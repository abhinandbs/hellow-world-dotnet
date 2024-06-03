using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.MultiThreading
{
    public  class TaskSample
    {
        public  void Main()
        {
          

            Task task = new Task(() => DoWork("car"));
            task.Start();

            Task task2 = Task.Run(()=> DoWork2("jeep"));
            //task2.Start();


             Task.WaitAll(task,task2);
            Console.WriteLine("main thread completed");


            //task.RunSynchronously();
            //Console.WriteLine("task started");



        }
        public  void DoWork(string name)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker Task: " + i + name);
                Thread.Sleep(1000); // Sleep for 100 milliseconds
            }
        }
        public void DoWork2(string name)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker Task: " + i + name);
                Thread.Sleep(1000); // Sleep for 100 milliseconds
            }
        }
    }
}
