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
    }
}
