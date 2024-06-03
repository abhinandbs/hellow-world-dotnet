using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.DesignPatterns.CreationalDesignPatterns.Singelton
{

    public class SingletonSample
    {

        private static SingletonSample? instance;


        private SingletonSample() { }

        public static SingletonSample Instance
        {
            get
            {
                if (instance == null)
                {

                    instance = new SingletonSample();
                    return instance;
                }
                else
                {
                    return instance;
                }
            }



        }
    }
}
