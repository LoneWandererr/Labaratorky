using System;

namespace _6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6. Дано число A. Вычислить A^8 , используя вспомогательную переменную и три операции умножения.");
            int A = Convert.ToInt32(Console.ReadLine());
            double b = Math.Pow(A,8) / Math.Pow(A,3);
            double a8 = A * A * A * b;
            Console.WriteLine($"A в 8 степени равна {a8}");
        }
    }
}
