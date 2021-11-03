using System;

namespace _5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). Найти его периметр и площадь");
            Console.WriteLine("Введите координаты первой вершины A");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины B");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины C");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            double a = Math.Abs(Math.Pow((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1), 0.5));
            double b = Math.Abs(Math.Pow((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1), 0.5));
            double c = Math.Abs(Math.Pow((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3), 0.5));
            double P = a+b+c;
            double p = P / 2;
            double S = Math.Pow(p*(p-a)*(p-b)*(p-c), 0.5);
            //Console.WriteLine($"Сторона а{a}");
            //Console.WriteLine($"Сторона b{b}");
            //Console.WriteLine($"Сторона c{c}");
            Console.WriteLine($"Периметр{P}");
            Console.WriteLine($"Площадь {S}");
        }
    }
}
