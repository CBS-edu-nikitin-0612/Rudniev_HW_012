using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Point
    {
        private double x, y;
        private string name;

        public double X { get => x; }
        public double Y { get => y; }
        public string Name { get => name; }

        public Point() { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = (name != null ? name : "A");
        }
    }
}
