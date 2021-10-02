using System;

namespace Lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). Найти его периметр и площадь");
            Console.WriteLine("Введите координаты первой вершины A");
            int x1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int y1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите координаты второй вершины B");
            int x2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int y2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите координаты третьей вершины C");
            int x3 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int y3 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            double AB = Math.Abs(Math.Pow((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1), 0.5));
            double AC = Math.Abs(x3 - x1);
            double CB = Math.Abs(y3 - y2);
            double P = AB + AC + CB;
            double S = 0.5 * CB * AC;
            Console.WriteLine($"Периметр{P}");
            Console.WriteLine($"Площадь {S}");
        }
    }
}
