using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.DelegateExamples
{

    // Step 1: Define a delegate
    public delegate void eventhandler(String message);

    public class Publisher
    {

        public event eventhandler eventhandler;

        public void RaiseEvent(String message)
        {

            eventhandler(message);
        }
    }


    public class Subscriber
    {
        public void onEvent(String message)
        {

            Console.WriteLine("Called Subscriber :"+message);
        }
    }
      
    

}
