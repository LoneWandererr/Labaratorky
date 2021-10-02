using System;

namespace Lab4But
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Даны стороны прямоугольника a и b. Найти его площадь S = a·b и периметр P = 2·(a + b).");
            Console.WriteLine("Введите значение а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Площадь : {a * b} ");
            Console.WriteLine($"Периметр :{2 * (a + b)}");

        }
    }
}
