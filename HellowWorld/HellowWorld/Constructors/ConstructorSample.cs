using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HellowWorld.Constructors
{
    public class ConstructorSample
    {

        public string? Sample { get; set; }
       

        //a class cannot have both a static constructor and a public (or instance) constructor with the same signature
        // In object-oriented programming, particularly in C#, constructors can be overloaded but not overridden.
        static ConstructorSample()
        {

            var car = 10;
            Console.WriteLine("Static Constructor Sample" +car);
        }


        public ConstructorSample()
        {
          
            Console.WriteLine("Public Constructor Sample1 ");
        }
        public ConstructorSample(string name, string name2)
        {

            Console.WriteLine("Public Constructor Sample " + name+ name2);
        }

        // Overloaded constructor with default values
        // Constructor chaining
        public ConstructorSample(string name): this(name,"abhinand")
        {
            Console.WriteLine("Public Constructor Sample2  "+Sample);
        }
        public  void Main()
        {
           
            Console.WriteLine("Main Method");
        }
    }
}
