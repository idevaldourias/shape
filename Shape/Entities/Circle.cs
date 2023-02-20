using Figure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() {}

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return double.Pi * (Radius * Radius);
        }
    }
}
