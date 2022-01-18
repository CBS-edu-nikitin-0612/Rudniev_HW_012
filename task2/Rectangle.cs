using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Rectangle
    {
        private double side1, side2;

        public double Side1 { get => side1; set => side1 = value > 0 ? value : 5; }
        public double Side2 { get => side2; set => side2 = value > 0 ? value : 5; }

        public Rectangle() { }
        public Rectangle(double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        private double AreaCalculator()
        {
            return side1 * side2;
        }
        private double PerimeterCalculator()
        {
            return side1 * 2 + side2 * 2;
        }

        public double Area { get => AreaCalculator(); }
        public double Perimeter { get => PerimeterCalculator(); }
    }
}
