using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.DesignPatterns.CreationalDesignPatterns.Singelton
{

    public class SingletonSample2
    {

        //The Lazy<T> class ensures that the instance of Singleton is created only when it is first accessed, and it is thread-safe,
        //meaning it can safely be used in a multithreaded environment without additional locking mechanisms

        private static readonly Lazy<SingletonSample2> singeltonSample2 = new Lazy<SingletonSample2>(() => new SingletonSample2());

        private SingletonSample2() { }

        public static SingletonSample2 Instance { get
            {

                return singeltonSample2.Value;
            } }

        
    }
}
