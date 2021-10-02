using System;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2. Дан диаметр окружности d. Найти ее длину L = π·d. В качестве значения π использовать 3.14.");
            Console.WriteLine("Введите значение d");
            int d = Convert.ToInt32(Console.ReadLine());
            double L = 3.14 * d;
            Console.WriteLine($"Диаметр окружности равен: {L}");

        }
    }
}