using System;

namespace Lab4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5. Даны два ненулевых числа. Найти сумму, разность, произведение и частное их модулей.");
            Console.WriteLine("Введите первое число ");
            float first = Math.Abs((Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("Введите второе число ");
            float sec = Math.Abs((Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine($"Сумма чисел:{first + sec}");
            Console.WriteLine($"Разность чисел:{first - sec}");
            Console.WriteLine($"Произведение чисел:{first * sec}");
            Console.WriteLine($"Частное чисел:{first / sec}");
        }
    }
}
