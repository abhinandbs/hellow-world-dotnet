using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.DesignPatterns.CreationalDesignPatterns
{
    public class AbstractFactoryPattern
    {

        public interface IDisplay
        {

            void DisplayScreen();
        }

        public interface ICharger
        {

            void ChargeSpeed();

        }
        public interface IBattery
        {

            void BatteryType();

        }

        public class SamsungDisplay : IDisplay
        {
            public void DisplayScreen()
            {

                Console.WriteLine("Super Amoled");
            }
        }

        public class AppleDisplay : IDisplay
        {
            public void DisplayScreen()
            {

                Console.WriteLine("Retina Display");
            }
        }


        public class SamsungCharge : ICharger
        {
            public void ChargeSpeed()
            {

                Console.WriteLine("45v");
            }


        }
        public class AppleCharge : ICharger
        {
            public void ChargeSpeed()
            {

                Console.WriteLine("18v");
            }


        }

        public class Battery : IBattery

        {
            public void BatteryType()
            {
                Console.WriteLine("5000 mah");
            }
        }

        public interface Iphone
        {
            IDisplay Display();
            ICharger Charger();

            void PhoneName();

            IBattery Battery();


        }

        public abstract class BasePhone
        {



            public virtual void PhoneName()
            {
                Console.WriteLine("phone");
            }

            public virtual IBattery Battery()
            {
                return new Battery();
            }
        }
        public class SamaungPhoneFactory : BasePhone, Iphone
        {


            public ICharger Charger()
            {
                return new SamsungCharge();
            }

            public IDisplay Display()
            {
                return new SamsungDisplay();
            }

            public override void PhoneName()
            {
                Console.WriteLine("Samung");
            }

        }


        public class ApplePhoneFactory : BasePhone, Iphone
        {
            public ICharger Charger()
            {
                return new AppleCharge();
            }

            public IDisplay Display()
            {
                return new AppleDisplay();
            }
            public override void PhoneName()
            {
                base.PhoneName();
                Console.WriteLine("Apple");
            }

        }


        public class PhoneFactory
        {

            public Iphone BuildPhone(string name)
            {
                if (name == "samsung")
                {

                    return new SamaungPhoneFactory();
                }
                else
                {
                    return new ApplePhoneFactory();
                }



            }
        }

        public static class AbstractFactorySample
        {

            public static void buildPhone()
            {
                PhoneFactory phoneFactory = new PhoneFactory();

                Iphone phone = phoneFactory.BuildPhone("samung");

                IDisplay display = phone.Display();

                display.DisplayScreen();

                ICharger charger = phone.Charger();

                charger.ChargeSpeed();

                phone.PhoneName();

                IBattery battery = phone.Battery();

                battery.BatteryType();


            }
        }






    }
}
