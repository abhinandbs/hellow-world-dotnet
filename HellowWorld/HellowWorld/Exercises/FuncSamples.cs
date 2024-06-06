
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Exercises
{
    public class FuncSamples
    {

        public void method()
        {

           Func<int,int,int> data = delegate(int x,int y) { 
               
               
               return x+y;
           
           };

            Func<int, int, int> add =(x,y)=>x+y;

            Action<string> printMessage = (message) => Console.WriteLine(message);
            // Predicate delegate with one input parameter (int) and a Boolean return value
            Predicate<int> isEven = (number) => number % 2 == 0;
            bool result = isEven(4); // Output: true
            ProcessData(data);
        }

        public void ProcessData(Func<int, int, int> data)
        {
            data(0, 0);
        }
        public async void MyAsyncMethod()
        {
            // Asynchronous operation
            await Task.Delay(1000);
            Console.WriteLine("Async operation completed.");
        }
        public async void MyAsyncMethod2()
        {
            // Asynchronous operation
             MyAsyncMethod();
        }
    }
}
