using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Constructors
{
    public class ConstructorSample
    {

        //a class cannot have both a static constructor and a public (or instance) constructor with the same signature
       // In object-oriented programming, particularly in C#, constructors can be overloaded but not overridden.
        static ConstructorSample()
        {

            var car = 10;
            Console.WriteLine("Static Constructor Sample" +car);
        }
        public ConstructorSample()
        {

            Console.WriteLine("Public Constructor Sample ");
        }

        public ConstructorSample(string name)
        {

            Console.WriteLine("Public Constructor Sample "+name);
        }
        public ConstructorSample(string name, string name2)
        {

            Console.WriteLine("Public Constructor Sample " + name+ name2);
        }

        public  void Main()
        {
           
            Console.WriteLine("Main Method");
        }
    }
}
