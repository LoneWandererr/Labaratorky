using System;

namespace Lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Найти расстояние между двумя точками с заданными координатами (x1, y1) и (x2, y2)");
            Console.WriteLine("Введите координаты точки А");
            int x1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int y1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите координаты точки B");
            int x2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int y2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите координаты точки C");
            int x3 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int y3 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            double AC = Math.Pow((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1), 0.5);
            double BC = Math.Pow((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2), 0.5);
            double sum = AC + BC;
            Console.WriteLine($"Длина АС {AC}");
            Console.WriteLine($"Длина BС {BC}");
            Console.WriteLine($"Cумма отрезков {sum}");
        }
    }
}
