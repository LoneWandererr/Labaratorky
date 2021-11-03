using System;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. Даны координаты двух противоположных вершин прямоугольника:(x1, y1), (x2, y2).Стороны прямоугольника параллельны осям координат.");
            Console.WriteLine("Введите координаты первой вершины");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double P = Math.Abs(x2 - x1) * 2 + Math.Abs(y2 - y1) * 2;
            double S = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
            Console.WriteLine($"Периметр {P}");
            Console.WriteLine($"Площадь {S}");
        }
    }
}
