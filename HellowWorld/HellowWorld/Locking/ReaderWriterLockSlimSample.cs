using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Locking
{
    public class ReaderWriterLockSlimSample
    {
        private ReaderWriterLockSlim _readerWriterLockSlim;
        private int _value;

        public int ReadData()
        {

            try
            {

                _readerWriterLockSlim.EnterReadLock();

                return _value;
                Console.WriteLine("reading data");

            }
            finally
            {

                _readerWriterLockSlim.ExitReadLock();
            }
        }

        public void WriteData(int val)
        {

            try
            {

                _readerWriterLockSlim.EnterWriteLock();

                Console.WriteLine("writing data");
                _value = val;

            }
            finally
            {

                _readerWriterLockSlim.ExitWriteLock();
            }
        }
    }
}
