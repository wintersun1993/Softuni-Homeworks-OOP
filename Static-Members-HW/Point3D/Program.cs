﻿/*
	*Create a class Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
	*Create appropriate constructors.
	*Implement the ToString() to enable printing a 3D point.
	*Add a private static read-only field in the Point3D class to hold the start
	 of the coordinate system – the point StartingPoint {0, 0, 0}.
	*Add a static property to return the starting point.

*/

using System;
using Point_3D;

class Program
{
    static void Main()
    {
        Point3D currentPoint = new Point3D(2, 4, 6);
        Console.WriteLine(currentPoint.ToString());
    }
}
