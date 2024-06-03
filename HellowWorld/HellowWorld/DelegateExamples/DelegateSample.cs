using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.DelegateExamples
{

    public delegate void MyDelegate(string message);

    public class DelegateSample
    {
        public static void Method1(string message)
        {
            Console.WriteLine("Method1: " + message);
        }

        public static void Method2(string message)
        {
            Console.WriteLine("Method2: " + message);
        }
        public static void Method3(string message, string message2)
        {
            Console.WriteLine("Method3: " + message + message2);
        }

    }
}
