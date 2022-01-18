using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Figure
    {
        private string name;
        public string Name { get => name; set => name = value; }
        private List<Point> figureStruct = new List<Point>();
        public Figure() { }
        public Figure(string name, Point A, Point B, Point C)
        {
            this.name = name;
            figureStruct.Add(A);
            figureStruct.Add(B);
            figureStruct.Add(C);
        }
        public Figure(string name, Point A, Point B, Point C, Point D)
        {
            this.name = name;
            figureStruct.Add(A);
            figureStruct.Add(B);
            figureStruct.Add(C);
            figureStruct.Add(D);
        }
        public Figure(string name, Point A, Point B, Point C, Point D, Point E)
        {
            this.name = name;
            figureStruct.Add(A);
            figureStruct.Add(B);
            figureStruct.Add(C);
            figureStruct.Add(D);
            figureStruct.Add(E);
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for(int i = 0; i < figureStruct.Count-1; i++)
            {
                perimeter += Math.Sqrt(Math.Pow(figureStruct[i].X - figureStruct[i+1].X, 2) + Math.Pow(figureStruct[i].Y - figureStruct[++i].Y, 2));
            }
            Console.WriteLine("perimeter " + name + ": " + perimeter);
        }
    }
}
