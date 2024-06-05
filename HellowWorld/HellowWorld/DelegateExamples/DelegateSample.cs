 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.DelegateExamples
{

    public delegate void MyDelegate(string message);

    public  class DelegateSample
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


        Action action1 = () => Console.WriteLine("Hello, world!");

        // Example of Action with one parameter
        Action<int> action2 = (x) => Console.WriteLine($"The value is: {x}");

        // Example of Action with two parameters
        Action<int, string> action3 = (x, y) => Console.WriteLine($"Values: {x}, {y}");

        // Example of Func with no parameters and a string return type
        Func<string> func1 = () => "Hello, world!";

        // Example of Func with one parameter (int) and a string return type
        Func<int, string> func2 = (x) => $"The value is: {x}";

        // Example of Func with two parameters (int, string) and an int return type
        Func<int, string, int> func3 = (x, y) => x + int.Parse(y);

 

        //action and func used for passing methods as parameter 
        //delegates




    }
}
