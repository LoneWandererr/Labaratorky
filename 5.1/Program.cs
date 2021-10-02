using System;

namespace Lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Найти расстояние между двумя точками с заданными координатами (x1, y1) и (x2, y2)");
            Console.WriteLine("Введите x1");
            int x1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите y1");
            int y1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите x2");
            int x2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите y2");
            int y2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int g = (x2-x1) * (x2 - x1) + (y2-y1)*(y2-y1);
            double S = Math.Pow(g, 0.5);
            Console.WriteLine($"Расстояние между точками {S}");
        }
    }
}
