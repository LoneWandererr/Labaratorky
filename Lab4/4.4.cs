using System;

namespace Lab4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов.");
            Console.WriteLine("Введите первое число ");
            float first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            float sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма чисел:{(first * first) + (sec * sec)}");
            Console.WriteLine($"Разность чисел:{(first * first) - (sec * sec)}");
            Console.WriteLine($"Произведение чисел:{(first * first) * (sec * sec)}");
            Console.WriteLine($"Частное квадратов чисел:{(first * first) / (sec * sec)}");


        }
    }
}