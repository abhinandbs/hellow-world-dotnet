using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.DeadLock
{
    public class DeadLockSample
    {

        //Thread A locks resource1 and then waits to lock resource2, which is locked by Thread B.
        //Meanwhile, Thread B locks resource2 and waits to lock resource1, which is locked by Thread A.
        //Neither thread can proceed because each is waiting for the other to release a resource, leading to a deadlock.


        object resource1 = new object();
        object resource2 = new object();

        void ThreadATask()
        {
            lock (resource1)
            {
                // Simulate long-running task
                Thread.Sleep(1000);

                lock (resource2)
                {
                    // Critical section
                }
            }
        }

        void ThreadBTask()
        {
            lock (resource2)
            {
                // Simulate long-running task
                Thread.Sleep(1000);

                lock (resource1)
                {
                    // Critical section
                }
            }
        }

    }
}
