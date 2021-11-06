using System;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2. Дано значение угла α в радианах (0 < α < 2•π). Определить значение этого же угла в градусах, учитывая, что 180◦ = π радианов");
            Console.WriteLine("Введите значение а");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine($"{a} раиданов это {a * (180 / 3.14)} градусов");
        }
    }
}
