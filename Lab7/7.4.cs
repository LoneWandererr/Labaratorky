using System;

namespace _7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. Скорость первого автомобиля V1 км/ч, второго — V2 км/ч, расстояние между ними S км. Определить расстояние между ними через T ");
            Console.WriteLine("Введите значение V1");
            float V1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение V2");
            float V2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение S");
            float S = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение T");
            float T = float.Parse(Console.ReadLine());
            double S2 = S + V1 * T + V2 * T;
            Console.WriteLine($"Расстояние между этими автомобилями через {T} часов - {S2} км");


        }
    }
}
