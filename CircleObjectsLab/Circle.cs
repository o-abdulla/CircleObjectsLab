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
        public double CalculateDiameter(double diameter)
        {
            return diameter = 2 * Radius;
        }
        public double CalculateCircumference(double circum)
        {
            return circum = 2 * Math.PI * Radius;
        }
        public double CalculateArea(double area)
        {
            return area = Math.PI * (Radius * Radius);
        }
        public void Grow()
        {
            Console.WriteLine("The circle is magically growing.");
        }
        public double GetRadius(double get)
        {
            return Radius * 2;
        }
    }
}
