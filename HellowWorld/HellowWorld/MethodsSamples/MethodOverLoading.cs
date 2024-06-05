using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.MethodsSamples
{
    public  class MethodOverLoading
    {
        //The methods have different numbers of parameters.
       // The methods have parameters of different types.
       // The methods have parameters in a different order.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 20));          // Calls Add(int, int)
            Console.WriteLine(Add(10.5, 20.5));      // Calls Add(double, double)
            Console.WriteLine(Add(10, 20, 30));      // Calls Add(int, int, int)
            Console.WriteLine(Add("Hello, ", "World!")); // Calls Add(string, string)
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static string Add(string a, string b)
        {
            return a + b;
        }
    }
}
