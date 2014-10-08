using System;

namespace Shapes
{
    class Triangle : BasicShape
    {
        public Triangle(double width,double height)
            : base(width, height)
        {

        }

        public override double CalculateArea()
        {
            return (Width * Height)/2;
        }

        public override double CalculatePerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width) + (Height * Height));
        }
    }
}
