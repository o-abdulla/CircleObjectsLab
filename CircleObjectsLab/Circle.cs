using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectsLab
{
    internal class Circle
    {
        //Properties
        private double Radius { get; set; }
        //Constructor
        public Circle(double _radius)
        {
            Radius = _radius;
        }
        //Methods
        public double CalculateDiameter()
        {
            return 2 * Radius;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public double CalculateArea()
        {
            return Math.PI * (Radius * Radius); // Math.Pow(Radius, 2)
        }
        public void Grow()
        {
            Radius *= 2;           // Radius = Radius * 2
        }
        public double GetRadius()
        {
            return Radius;
        }
    }
}
