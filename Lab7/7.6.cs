using System;

namespace _7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6. Найти решение системы линейных уравнений вида ");
            Console.WriteLine("A1•x + B1•y = C1");
            Console.WriteLine("A2•x + B2•y = C2");
            Console.WriteLine("Введите А1");
            float A1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите B1");
            float B1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите C1");
            float C1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите А2");
            float A2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите B2");
            float B2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите C2");
            float C2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Полученные уравнения :");
            Console.WriteLine($"{A1}x + {B1}y = {C1}");
            Console.WriteLine($"{A2}x + {B2}y = {C2}");
            double delta = A1 * B2 - B1 * A2;
            double delta1 = C1 * B2 - C2 * B1;
            double delta2 = A1 * C2 - C1 * A2;
            double x = delta1 / delta;
            double y = delta2 / delta;
            Console.WriteLine($"Ответ : x = {x}, y = {y}");

        }
    }
}
