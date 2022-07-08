using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeterCalc
{
    internal class Program
    {
        static void Main(String[] Args)
        {
            int x = 12;
            int y = 19;
            int z = 13;

            var myCircle = new Circle(x);
            Console.WriteLine();
            Console.WriteLine("Area of the Circle is: " + Math.Round(myCircle.calculateArea(), 3));
            Console.WriteLine();
            Console.WriteLine("Perimeter of the Circle is: " + Math.Round(myCircle.calculatePerimeter(), 3));
            Console.WriteLine();

            var myRectangle = new Rectangle(y, z);
            Console.WriteLine();
            Console.WriteLine("Area of the Rectangle is: " + Math.Round(myRectangle.calculateArea(), 3));
            Console.WriteLine();
            Console.WriteLine("Perimeter of the Rectangle is: " + Math.Round(myRectangle.calculatePerimeter(), 3));
            Console.WriteLine();

            Console.ReadLine();
        }
    } 
}


    public abstract class Shape
    {
        public abstract double calculateArea();

        public abstract double calculatePerimeter();
    }

    class Circle : Shape
    {
        private static float PI = 3.14f;
        public double radius { get; set; }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override double calculateArea()
        {
            double area = (PI * (radius * radius));
            return area;
        }

        public override double calculatePerimeter()
        {
            double perimeter = (2 * PI * radius);
            return perimeter;
        }
    }

    class Rectangle : Shape
    {
        public double length { get; set; }

        public double width { get; set; }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public override double calculateArea()
        {
            double area = length * width;
            return area;
        }

        public override double calculatePerimeter()
        {
            double perimeter = 2 * (length + width);
            return perimeter;
        }
    }