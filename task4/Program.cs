using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure newFigure = new Figure("rectangle", new Point(2, 2), new Point(2, -2), new Point(-2, -2), new Point(-2, 2));
            newFigure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
