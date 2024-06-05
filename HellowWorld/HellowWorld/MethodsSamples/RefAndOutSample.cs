using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.MethodsSamples
{
    public class RefAndOutSample
    {
        public void RefSample()
        {
            var name = " Ref Test";

            RefData(ref name);

            Console.WriteLine(name);

        }

        public void OutSample()
        {
           
           OutData(out string name);

    
            Console.WriteLine(name);

        }
        private string OutData(out string name)
        {
            name= "Out Test";
            name = name + "name";
            return name;
        }


        private string RefData(ref string name) {

            name = name + "name";
            return name;
        }
    }
}
