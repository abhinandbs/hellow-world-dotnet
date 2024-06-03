using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Locking
{
    public class LockSample
    {
      
        private readonly Object _lock = new Object();

        public void RunData()
        {
            lock (_lock)
            {
                Console.WriteLine("Locked");
            }

        }
        
    }
}
