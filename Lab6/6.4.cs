using System;

namespace _6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. Найти значение функции y = 3x^6 - 6x^2 - 7 при данном значении x");
            int x = Convert.ToInt32(Console.ReadLine());        
            double y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
            Console.WriteLine($"y = 3*{x}^6 - 6*{x}^2 - 7 = {y}");
        }
    }
}
