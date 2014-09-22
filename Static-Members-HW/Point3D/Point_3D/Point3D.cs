using System;

namespace Point_3D
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D startPoint;

        static Point3D()
        {
            Point3D.startPoint = new Point3D(0, 0, 0);
        }

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

        public static Point3D GetStart
        {
            get 
            {
                return Point3D.startPoint;
            }
        }

        public override string ToString()
        {
            return "{" + this.X + "," + this.Y + "," + this.Z + "}";
        }
    }
}
