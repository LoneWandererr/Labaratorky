using System;

namespace _7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Дано значение угла α в градусах (0 < α < 360). Определить значение этого же угла в радианах, учитывая, что 180◦ = π радианов. ");
            Console.WriteLine("Введите значение а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} градусов это {a/(180/3.14)} радианов");
                


        }

    }
}
