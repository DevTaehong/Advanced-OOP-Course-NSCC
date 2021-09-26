using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S5
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square() { Width = 2 };
            var triagnle = new Triangle() { Base = 2, Height = 5 };
            var circle = new Circle() { Radius = 3 };

            square.Display();
            triagnle.Display();
            circle.Display();

        }
    }

    abstract class Shape
    {
        public abstract double GetArea();

        public void Display()
        {
            Console.WriteLine("The area is {0}", GetArea());
        }
    }
    class Square : Shape
    {
        public int Width;

        public override double GetArea()
        {
            return Width * Width;
        }


    }

    class Triangle : Shape
    {
        public int Base;
        public int Height;

        public override double GetArea()
        {
            return (Base * Height) / 2;
        }
    }

    class Circle : Shape
    {
        public int Radius;

        public override double GetArea()
        {
            return (Radius * Radius) * Math.PI;
        }
    }
}
