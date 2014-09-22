using System;

namespace DistanceCalculator_3D
{
    static class DistanceCalculator
    {   
        public static double Distance(Point3D firstPoint,Point3D secondPoint)
        {
            return Math.Abs(firstPoint.pythagorean - secondPoint.pythagorean);
        }
    }
}
