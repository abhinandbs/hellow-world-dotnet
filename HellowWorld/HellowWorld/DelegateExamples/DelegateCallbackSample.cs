using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.DelegateExamples
{

    public delegate void CallBackDelegate(string name);
    public static class DelegateCallbackSample
    {

        public static void ProcessFile(string name, CallBackDelegate callback)
        {
          
            // Invoke the callback method
            callback(name);
        }
    }


}
