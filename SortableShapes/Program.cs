using System;
using System.Collections.Generic;
using System.Linq;

namespace SortableShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = 1.1234;
            double radius = 1.1234;
            double basee = 5;
            double height = 2;
            double width = 3;
            var shapes = new List<Shape>
            {
                new Square(side),
                new Rectangle(width, height),
                new Triangle(basee, height),
                new Circle(radius)

            };
            Console.WriteLine("The list before sorting:");
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine("{0}.{1} : {2}", i + 1, shapes[i].Title, shapes[i].Area);
            }
            shapes.Sort();
            Console.WriteLine("\nThe list is sorted:");
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine("{0}.{1} : {2}", i + 1, shapes[i].Title, shapes[i].Area);
            }
            Console.ReadKey();
            
        }
    }

    class Shape : IComparable<Shape>
    {
        public double Area;
        public string Title;

        public int CompareTo(Shape nextElement)
        {
            return this.Area.CompareTo(nextElement.Area);
        }
    }

    class Square : Shape
    {
        public Square (double side)
        {
            Title = "Square";
            Area = side * side;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            Title = "Rectangle";
            Area = width * height;
        }
    }

    class Triangle : Shape
    {
        public Triangle (double basee, double height)
        {
            Title = "Triangle";
            Area = (basee * height) / 2;
        }
    }

    class Circle : Shape
    {
        public Circle (double radius)
        {
            Title = "Circle";
            Area = (radius * radius) * Math.PI;
        }

    }


}
