using System;

namespace _6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7. Дано число A. Вычислить A*15, используя две вспомогательные переменные и пять операций умножения.");
            int A = Convert.ToInt32(Console.ReadLine());
            double b = Math.Pow(A, 15) / Math.Pow(A, 10);
            double c = Math.Pow(A, 15) / Math.Pow(A, 9);
            double a8 = A * A * A * A * b * c;
            Console.WriteLine($"A в 15 степени равна {a8}");
        }
    }
}
