/*
    •Define an interface IShape with two abstract methods: CalculateArea() and CalculatePerimeter().
    •Define an abstract class BasicShape implementing IShape and holding width and height.
     Leave the methods CalculateArea() and CalculatePerimeter() abstract.
    •Define two new BasicShape subclasses: Triangle and Rectangle that implement the abstract methods
     CalculateArea() and CalculatePerimeter().
    •Define a class Circle with a suitable constructor and IShape.
    •Create an array of different shapes (Circle, Rectangle, Triangle) and test the behavior
     of the CalculateSurface() and CalculatePerimeter() methods.

 */

using System;
using Shapes;
using System.Collections.Generic;

class TestShapes
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(10, 5);
        Circle circ = new Circle(10);
        Triangle triangle = new Triangle(20, 10);

        List<IShape> shapes = new List<IShape>();
        shapes.Add(rect);
        shapes.Add(triangle);
        shapes.Add(circ);

        foreach (var shape in shapes)
        {
            Console.WriteLine("The area of the " + shape.GetType().Name + " is " + shape.CalculateArea()
                + " and the Perimeter is " + shape.CalculatePerimeter());
        }
    }
}

