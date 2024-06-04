using HellowWorld.Constructors;
using HellowWorld.DelegateExamples;
using HellowWorld.DesignPatterns.CreationalDesignPatterns;
using HellowWorld.DesignPatterns.CreationalDesignPatterns.Singelton;
using HellowWorld.Extensions;
using HellowWorld.InheritanceSample;
using HellowWorld.ListSample;
using HellowWorld.Locking;
using HellowWorld.MethodsSamples;
using HellowWorld.MultiThreading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HellowWorld.DesignPatterns.CreationalDesignPatterns.AbstractFactoryPattern;

namespace HellowWorld
{
    public static class Examples
    {

        /// <summary>
        /// 
        /// </summary>
        public static void SampleExamples()
        {

           ExampleTitle("Singelton Example");

            SingletonExample();

            //ExampleTitle("Extension Example");

            //ExtensionExample();

            //ExampleTitle("Unique List Example");

            //UniqueListExample();

            // ExampleTitle("Sempahore");

            // SempahoreExample();

            // ExampleTitle("Delegate Example");

            // DelegateExample();

            //ExampleTitle("Thread Example");

            // ThreadExample();

            //  ExampleTitle("Task Sample");

            //  TaskExample();

            //ExampleTitle("Factory Sample");

            //  FactoryExample();

            // ExampleTitle("Abstract Factory Sample");

            // AbstractFactoryExample();

            // ExampleTitle("Auto Reset Event Sample");

            //   AutoResetEventExample();

            //  ExampleTitle("Manual Reset Event Sample");

            //  ManualResetEventExample();

            //  ExampleTitle("SimpleInheritanceExample");

            //  SimpleInheritanceExample();

            // ExampleTitle("StaticConstructorSample");

            //ConstructorExamples();

            ExampleTitle("Ref Out Sample");

            RefAndOutExample();
        }

        private static void ExampleTitle(string name)
        {
            Console.WriteLine("\n");
            Console.WriteLine(name);
            Console.WriteLine("------------------------------------------");

        }

        private static void SingletonExample()
        {

            var instance1 = SingletonSample3.Instance;

            var instance2 = SingletonSample3.Instance;

            if (ReferenceEquals(instance1, instance2))
            {

                Console.WriteLine("instances are equal");
            }
            else
            {
                Console.WriteLine("instance are different");

            }
        }

        private static void UniqueListExample()
        {

            //Unique List example
            UniqueList.UniqueSampleList();
        }

        private static void ExtensionExample()
        {

            //Extension example
            Console.WriteLine("Parse string to int");
            var data = "1".TryParseInt();
            Console.WriteLine(data);
        }


        private static void SempahoreExample()
        {

            SemaphoreSample.Main();
        }

        private static void DelegateExample()
        {

            MyDelegate myDelegate1 = new MyDelegate(DelegateSample.Method1);
            MyDelegate myDelegate2 = new MyDelegate(DelegateSample.Method2);

            myDelegate1("called");

            var myDelegate3 = myDelegate1 + myDelegate2;

            myDelegate3("call together");

            myDelegate3 -= myDelegate1;

            myDelegate3!("removed one method");

            MyDelegate mydelegate4 = delegate (string message)
            {
                Console.WriteLine(message);
            };

            mydelegate4("method4");

            MyDelegate myDelegate5 = (message) => { Console.WriteLine("Lambda expression: " + message); };

            myDelegate5("lamda");

            //call back

            DelegateCallbackSample.ProcessFile("callback sample", DelegateSample.Method1);



            Publisher publisher = new Publisher();
            Subscriber subscriber1 = new Subscriber();
          

            // Step 4: Subscribe to the event
            publisher.eventhandler += subscriber1.onEvent;
            

            // Raise the event
            publisher.RaiseEvent("Hello, Subscribers!");
        }


        private static void ThreadExample()
        {

            ThreadSample.Main();
        }

        private static void TaskExample()
        {
            TaskSample sample = new TaskSample();
            sample.Main();
        }

        private static void FactoryExample()
        {

            FactorySample.ProcessShape();
        }

        private static void AbstractFactoryExample()
        {

            AbstractFactorySample.buildPhone();
        }

        private static void AutoResetEventExample()
        {

            AutoResetEventSample.Producer();
            AutoResetEventSample.Consumer();
        }

        private static void ManualResetEventExample()
        {

            ManualResetEventSample.Main();
        }

        private static void SimpleInheritanceExample()
        {

            Base carBase = new Base();

            carBase.Method1();

            Child carChild = new Child();

            carChild.Method2();

            Base carBase2 = new Child();

            carBase2.Method1();
        }

        private static void ConstructorExamples() {

            ConstructorSample staticConstructorSample = new ConstructorSample();
            ConstructorSample staticConstructorSample2 = new ConstructorSample();
            

            staticConstructorSample.Main();
            staticConstructorSample2.Main();
            


        }

         private static void RefAndOutExample()
        {
            RefAndOutSample refAndOutSample = new RefAndOutSample();

            refAndOutSample.RefSample();
            refAndOutSample.OutSample();


        }
    }
}




  

   