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

          var newName =  RefData(ref name);

            Console.WriteLine(newName);

        }

        public void OutSample()
        {
           
            var newName = OutData(out string name);

            Console.WriteLine(newName);

        }
        private string OutData(out string name)
        {
            name= "Out Test";
            return name + "name";
        }


        private string RefData(ref string name) {

            return name + "name";
        }
    }
}
