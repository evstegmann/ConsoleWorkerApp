using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return (Radius * Radius) * 3.14;
        }
    }
}
