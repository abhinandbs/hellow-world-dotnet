using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Extensions
{
    public static class SampleExtension
    {
        public static int? TryParseInt(this string value)
        {
            if(int.TryParse(value,out  int result))
            {
                return result;
            }else { return null; }
        }

        public static int? UpdateTest(this Person person)
        {
            return 0;
        }
    }

    public class Person
    {

       public string? Name { get; set; }

        public void car()
        {

        }
    }

    public class MainClass
    {

        void MainMethod()
        {
            Person person1 = new Person { Name = "abhinand" };
            
            var result = person1.UpdateTest();

            person1.car();

        }
        




    }

}
