using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.InheritanceSample
{
    public class Base
    {
        public void Method1()
        {

            Console.WriteLine("car is a vehicle");
        }

        public void Method2()
        {

            Console.WriteLine("car is a vehicle");
        }
    }

    public class Child :Base
    {
        public new void Method1()
        {

            Console.WriteLine("car is a tata vehicle");
        }
        public new void Method2()
        {

            Console.WriteLine("car is a tata vehicle");
        }
    }


}
