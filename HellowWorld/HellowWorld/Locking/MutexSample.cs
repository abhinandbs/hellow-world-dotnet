using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Locking
{
    public class MutexSample
    {

        // Static to ensure only one instance exists for the whole application
        private static Mutex _mutex = new Mutex();


        public void ReadData()
        {

            _mutex.WaitOne();

            try
            {
                Task.Delay(1000);
                Console.WriteLine("Waiting");

            }

            finally { _mutex.ReleaseMutex(); }
        }
    }
}
