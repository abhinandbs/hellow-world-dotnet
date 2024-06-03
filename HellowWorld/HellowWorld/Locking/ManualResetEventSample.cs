using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Locking
{
    public static class ManualResetEventSample
    {
        private static ManualResetEvent manualResetEvent = new ManualResetEvent(false);
        private static Queue<int> itemQueue = new Queue<int>();
        private static Random random = new Random();
        private static bool done = false;

        public static void Main()
        {
            // Start producer and consumer threads
            Thread producerThread = new Thread(Producer);
            Thread consumerThread1 = new Thread(Consumer);
            Thread consumerThread2 = new Thread(Consumer);

            producerThread.Start();
            consumerThread1.Name = "Consumer1";
            consumerThread1.Start();

            consumerThread2.Name = "Consumer2";
            consumerThread2.Start();

            // Wait for producer thread to complete
            producerThread.Join();

            // Signal that production is complete
            done = true;
            manualResetEvent.Set(); // Signal all waiting consumers to proceed

            // Wait for consumer threads to complete
            consumerThread1.Join();
            consumerThread2.Join();

            Console.WriteLine("Processing complete.");
        }

        static void Producer()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (itemQueue)
                {
                    int item = random.Next(100);
                    itemQueue.Enqueue(item);
                    Console.WriteLine($"Produced: {item}");
                }

                manualResetEvent.Set(); // Signal consumers that an item is produced
                Thread.Sleep(500); // Simulate time taken to produce an item
                manualResetEvent.Reset(); // Reset the event for the next item
            }
        }

        static void Consumer()
        {
            while (true)
            {
                manualResetEvent.WaitOne(); // Wait for the signal from the producer

                if (done && itemQueue.Count == 0)
                {
                    break; // Exit loop if production is done and queue is empty
                }

                lock (itemQueue)
                {
                    if (itemQueue.Count > 0)
                    {
                        int item = itemQueue.Dequeue();
                        Console.WriteLine($"{Thread.CurrentThread.Name} consumed: {item}");
                    }
                }
            }
        }
    }
}
