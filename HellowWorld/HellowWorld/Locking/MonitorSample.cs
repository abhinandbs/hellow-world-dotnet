using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Locking
{
    public class MonitorSample
    {
        private readonly Object _lock = new Object();
        private static readonly object _lockObject = new object();
        private static bool _isKid1Turn = true; // Indicates whose turn it is

        public void RunData()
        {

           

            try
            {
                Monitor.Enter(_lock);

                Task.Delay(1000).Wait();

                Console.WriteLine("Processed Data");

            }finally{
             
                Monitor.Exit(_lock);
            }
           
        }

    

        public static void Main()
        {
            Thread kid1 = new Thread(Kid1Play);
            Thread kid2 = new Thread(Kid2Play);

            kid1.Start();
            kid2.Start();

            kid1.Join();
            kid2.Join();
        }

        static void Kid1Play()
        {
            for (int i = 0; i < 5; i++) // Each kid plays 5 times
            {
                lock (_lockObject)
                {
                    while (!_isKid1Turn) // Wait for Kid1's turn
                    {
                        Monitor.Wait(_lockObject);
                    }

                    Console.WriteLine("Kid 1 is playing with the toy car.");
                    Thread.Sleep(500); // Simulate playing time

                    _isKid1Turn = false; // Switch turn to Kid 2
                    Monitor.Pulse(_lockObject); // Notify Kid 2
                }
            }
        }

        static void Kid2Play()
        {
            for (int i = 0; i < 5; i++) // Each kid plays 5 times
            {
                lock (_lockObject)
                {
                    while (_isKid1Turn) // Wait for Kid2's turn
                    {
                        Monitor.Wait(_lockObject);
                    }

                    Console.WriteLine("Kid 2 is playing with the toy car.");
                    Thread.Sleep(500); // Simulate playing time

                    _isKid1Turn = true; // Switch turn to Kid 1
                    Monitor.Pulse(_lockObject); // Notify Kid 1
                }
            }
        }

    }
}
