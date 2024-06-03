using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Locking
{
    public  static class AutoResetEventSample
    {
        private static AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        public static void Producer()
        {
            Console.WriteLine("Producer Work Started");
            Task.Delay(5000).Wait();
            Console.WriteLine("Producer Work Completed");
            autoResetEvent.Set(); 
        }

        public static void Consumer()
        {
            // Wait for signal
            // Continue with the work after signal is received

         
            autoResetEvent.WaitOne();
            Console.WriteLine("Consumer Work Completed");
        }
    }
}
