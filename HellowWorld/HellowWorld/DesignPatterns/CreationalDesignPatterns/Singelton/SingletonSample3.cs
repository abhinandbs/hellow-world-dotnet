using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.DesignPatterns.CreationalDesignPatterns.Singelton
{

    public class SingletonSample3
    {

        private static SingletonSample3? instance;

        private static readonly object padLock = new object();


        private SingletonSample3() { }

        public static SingletonSample3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padLock)
                    {
                        if (instance == null)
                        {
                            {
                                instance = new SingletonSample3();

                            }
                        }

                    }

                }

                return instance;
            }



        }
    }
}
