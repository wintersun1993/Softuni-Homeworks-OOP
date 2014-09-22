using System;
using DistanceCalculator_3D;

class TestDistance
{
    static void Main()
    {
        Point3D first = new Point3D(-4, -1, -3);
        Point3D second = new Point3D(1, 2, 3);
        Console.WriteLine(DistanceCalculator.Distance(first,second));
    }
}

