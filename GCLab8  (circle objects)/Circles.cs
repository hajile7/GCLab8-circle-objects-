using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab8___circle_objects_
{
    internal class Circle
    {
        //properties
        private double radius { get; set; }

        //constructor
        public Circle(double _radius)
        {
            radius = _radius;
        }
        public double CalculateDiameter()
        {
            return radius * 2;
        }
        public double CalculateCircumference()
        {
            return (Math.PI * 2 * radius);
        }
        public double CalculateArea()
        {
            return Math.PI * (radius * radius);
        }
        public void Grow()
        {
            radius *= 2;
        }
        public double GetRadius()
        {
            return radius;
        }
    }
}
