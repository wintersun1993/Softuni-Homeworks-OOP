using System;

namespace DistanceCalculator_3D
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X
        {
            get
            {
                return this.x;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
        }
        
        public double pythagorean
        {
            get
            {
                return Math.Sqrt((this.X * this.X) + (this.Y * this.Y) + (this.Z * this.Z));
            }
        }
    }
}
