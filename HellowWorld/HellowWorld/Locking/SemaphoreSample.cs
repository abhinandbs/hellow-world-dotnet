using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Locking
{
    public class SemaphoreSample
    {
        // can be static as well as non static depend on usecases.
        private static Semaphore _semaphore = new Semaphore(3, 3);
        private static SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(3);

        public static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                // Create and start new threads
                Thread t = new Thread(new ParameterizedThreadStart(AccessResource));
                t.Start(i);
            }
        }

        private static void AccessResource(object id)
        {
            Console.WriteLine($"Thread {id} is waiting to access the resource...");

            // Wait for the semaphore to allow access
            _semaphore.WaitOne();

            
            Console.WriteLine($"Thread {id} is granted access to the resource.");
            // Simulate work by sleeping for 2 seconds
            Thread.Sleep(2000);

            Console.WriteLine($"Thread {id} is releasing the resource.");
            // Release the semaphore
            _semaphore.Release();



            //semaphore slim

            _semaphoreSlim.Wait();


            _semaphoreSlim.Release();
        }

    }
}
