using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.MultiThreading
{
    public class CancelationToken
    {
        static void Main(string[] args)
        {
            // Create a CancellationTokenSource
            CancellationTokenSource cts = new CancellationTokenSource();

            // Create and start a new thread
            Thread workerThread = new Thread(() => DoWork(cts.Token));
            workerThread.Start();

            // Wait for a while and then request cancellation
            Thread.Sleep(2000);
            Console.WriteLine("Requesting cancellation...");
            cts.Cancel();

            // Wait for the worker thread to exit
            workerThread.Join();
            Console.WriteLine("Worker thread has exited.");
        }

        static void DoWork(CancellationToken token)
        {
            while (true)
            {
                // Check for cancellation request
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Cancellation requested. Exiting...");
                    break; // Exit the loop and the thread
                }

                // Simulate work
                Console.WriteLine("Working...");
                Thread.Sleep(500);
            }
        }

        static void Main2(string[] args)
        {
            Thread workerThread = new Thread(DoWork);
            workerThread.Start();

            // Wait for a while and then abort the thread
            Thread.Sleep(2000);
            Console.WriteLine("Aborting thread...");
            workerThread.Abort(); // Discouraged

            // Wait for the worker thread to exit
            workerThread.Join();
            Console.WriteLine("Worker thread has exited.");
        }

        static void DoWork()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Working...");
                    Thread.Sleep(500);
                }
            }
            catch (ThreadAbortException)
            {
                Console.WriteLine("Thread aborted.");
            }
        }
    }
}
