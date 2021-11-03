using System;

namespace _6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5. Найти значение функции y = 4(x−3)6 − 7(x−3)3 + 2 при данном значении x");
            int x = Convert.ToInt32(Console.ReadLine());
            double y = 4 * (x - 3) * 6 - 7 * (x - 3) * 3 + 2;
            Console.WriteLine($"4 * ({x} - 3) * 6 - 7 * ({x} - 3) * 3 + 2 = {y}");
        }
    }
}
