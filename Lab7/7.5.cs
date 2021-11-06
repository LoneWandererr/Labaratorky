using System;

namespace _7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5. Решить линейное уравнение A•x + B = 0, заданное своими коэффициентами A и B (коэффициент A не равен 0).");
            Console.WriteLine("Введите значение А");
            float A = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение B");
            float B = float.Parse(Console.ReadLine());
            Console.WriteLine($"Уравнение : {A}x + {B} = 0");
            double x = (-1 * B) / A;
            Console.WriteLine($"Ответ: x = {x}");

        }
    }
}
