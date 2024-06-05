using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Exercises
{
    public static class ExercisesSample
    {

         public static void Method()
        {

            Main.MainMethod();
        }

      

        public interface IEngine
        {
            void EngineType();
        }
        public interface IWheel
        {
            void WheelType();

        }


        public class SportsWheel : IWheel
        {
            public void WheelType()
            {
                Console.WriteLine("Sports Wheel");
            }
        }
        public interface ITransmission
        {
            void TransmissionType();
        }

        // Implementations of Engine
        public class DieselEngine : IEngine
        {
            public void EngineType()
            {
                Console.WriteLine("Diesel Engine");
            }
        }

        public class PetrolEngine : IEngine
        {
            public void EngineType()
            {
                Console.WriteLine("Petrol Engine");
            }
        }

        // Implementations of Transmission
        public class AutomaticTransmission : ITransmission
        {
            public void TransmissionType()
            {
                Console.WriteLine("Automatic Transmission");
            }
        }

        public class ManualTransmission : ITransmission
        {
            public void TransmissionType()
            {
                Console.WriteLine("Manual Transmission");
            }
        }

        // Interface for Vehicle
        public interface IVehicle
        {
            IEngine CreateEngine();
            ITransmission CreateTransmission();
        }

        public interface ICarVehicle:IVehicle
        {
            IWheel CreateWheel();
        }
        // Concrete Vehicle Implementations
        public class PetrolAutomatic : IVehicle
        {
            public IEngine CreateEngine()
            {
                return new PetrolEngine();
            }

            public ITransmission CreateTransmission()
            {
                return new AutomaticTransmission();
            }
        }

        public class DieselAutomatic : IVehicle
        {
            public IEngine CreateEngine()
            {
                return new DieselEngine();
            }

            public ITransmission CreateTransmission()
            {
                return new AutomaticTransmission();
            }
        }

        public class DieselAutomaticCar : IVehicle,ICarVehicle
        {
            public IEngine CreateEngine()
            {
                return new DieselEngine();
            }

            public ITransmission CreateTransmission()
            {
                return new AutomaticTransmission();
            }

            public IWheel CreateWheel()
            {
                return new SportsWheel();
            }

           
        }

        // Vehicle Factory

        public class VehcileFactory
        {
            private readonly IVehicle _vehicle;
            public VehcileFactory(IVehicle vehicle)
            {

                _vehicle = vehicle;

            }


             public void CreateVehicle()
            {
                _vehicle.CreateEngine();
                _vehicle.CreateTransmission();
            }
        }

        public static class Main
        {

            public static void MainMethod()
            {
                IVehicle vehicle = new DieselAutomatic();
                IVehicle vehicle2 = new PetrolAutomatic();

                VehcileFactory vehcileClient = new VehcileFactory(vehicle);
         
                vehcileClient.CreateVehicle();
               


            }
        }

        


    }




}


   



