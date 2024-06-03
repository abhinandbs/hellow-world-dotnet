using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.DeadLock
{
    internal class DeadLockSample2
    {
        object resource1 = new object();
        void ThreadATask()
        {
            bool lockTaken = false;
            try
            {
                Monitor.TryEnter(resource1,TimeSpan.FromSeconds(10),ref lockTaken);
                if (!lockTaken)
                {
                    // Handle inability to acquire lock
                    return;
                }

                // Critical section
            }
            finally
            {
                if (lockTaken)
                {
                    Monitor.Exit(resource1);
                }
            }
        }
    }
}
