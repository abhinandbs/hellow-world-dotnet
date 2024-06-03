using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace HellowWorld.DependencyInjection
{
    public  class UnitySample
    {
        public void Start()
        {
            IUnityContainer container = new UnityContainer();

            // Register the type mapping
            container.RegisterType<ICar, Car>();
   

            // Resolve the dependency
            ICar car = container.Resolve<ICar>();
            car.Drive();

            // Or resolve it through another class
            Driver driver = container.Resolve<Driver>();
            driver.StartDriving();
        }

 
    }
    public interface ICar
    {
        void Drive();
    }

    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car...");
        }
    }

    public class Driver
    {
        private readonly ICar _car;

        public Driver(ICar car)
        {
            _car = car;
        }

        public void StartDriving()
        {
            _car.Drive();
        }
    }
}
