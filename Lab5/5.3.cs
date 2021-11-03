using System;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. Даны три точки A, B, C на числовой оси. Точка C расположенамежду точками A и B.Найти произведение длин отрезков AC и BC)");
            Console.WriteLine("Введите координаты точки А");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки C");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            double AC = Math.Pow(Math.Abs(x3 - x1) * Math.Abs(x3 - x1) + Math.Abs(y3 - y1) * Math.Abs(y3 - y1), 0.5);
            double BC = Math.Pow(Math.Abs(x3 - x2) * Math.Abs(x3 - x2) + Math.Abs(y3 - y2) * Math.Abs(y3 - y2), 0.5);
            double um = AC * BC;
            Console.WriteLine($"Длина АС {AC}");
            Console.WriteLine($"Длина BС {BC}");
            Console.WriteLine($"Произведение длин отрезков {um}");
        }
    }
}
