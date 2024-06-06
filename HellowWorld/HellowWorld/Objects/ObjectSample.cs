using HellowWorld.InheritanceSample;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HellowWorld.Exercises.ExercisesSample;

namespace HellowWorld.Objects
{
    public class ObjectSample
    {
        // Base Type: object is the base type for all types in C#. Any type, whether value type or reference type, can be assigned to a variable of type object.
        void method()
        {
            dynamic something = 42;
            something = "Now I'm a string!";


            int number = 42; // Value type stored on the stack
            object boxedNumber = number;// Boxing: value type is wrapped in an object and stored on the heap

            object boxedNumbers = 42; // Boxing
            int unboxedNumber = (int)boxedNumbers; // Unboxing: extracting the value type from the object

            ArrayList list = new ArrayList();

            int number1 = 123;       // Value type
            list.Add(number1);       // Boxing occurs here

            object boxedNumber2 = list[0]; // The stored integer is now a boxed object
            int unboxedNumber3 = (int)boxedNumber;
        }
    }
}
