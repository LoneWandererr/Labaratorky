using System;

namespace Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Найти расстояние между двумя точками с заданными координатами (x1, y1) и (x2, y2)");
            Console.WriteLine("Введите x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            int g = Math.Abs(x2 - x1) * Math.Abs(x2 - x1) + Math.Abs(y2 - y1) * Math.Abs(y2 - y1);
            double S = Math.Pow(g, 0.5);
            Console.WriteLine($"Расстояние между точками {S}");
        }
    }
}
