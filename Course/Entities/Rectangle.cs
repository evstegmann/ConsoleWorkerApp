using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
