using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            bool bool01, bool02;
            do {
                Console.Write("Введите длину основания прямоугольника: ");
                bool01 = double.TryParse(Console.ReadLine().Replace('.', ','), out a);
                Console.Write("Введите длину высоты прямоугольника: ");
                bool02 = double.TryParse(Console.ReadLine().Replace('.', ','), out b);
            } while (!bool01 || !bool02);

            var rectangle01 = new Rectangle(a, b);
            Console.WriteLine(new string('_', 50));
            Console.WriteLine("Area: " + rectangle01.Area);
            Console.WriteLine("Perimeter: " + rectangle01.Perimeter);
            Console.ReadKey();

        }
    }
}
