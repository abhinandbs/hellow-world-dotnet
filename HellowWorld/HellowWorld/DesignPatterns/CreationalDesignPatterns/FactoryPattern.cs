using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.DesignPatterns.CreationalDesignPatterns
{

    public interface IShape
    {

        string Draw();
    }

    public class Circle : IShape
    {
        public string Draw()
        {
            return "Circle";
        }
    }

    public class Square : IShape
    {


        public string Draw()
        {
            return "Square";
        }
    }


    public static class ShapeFactory
    {
        public static IShape CreateShape(string name)
        {
            if (name == "Circle")
            {
                return new Circle();
            }
            else
            {
                return new Square();
            }
        }

    }


    public static class FactorySample
    {
        public static void ProcessShape()
        {
            IShape shape = ShapeFactory.CreateShape("Square");
            Console.WriteLine(shape.Draw());
        }


    }







}
