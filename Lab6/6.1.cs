using System;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Поменять местами содержимое переменных A и B и вывести новые значения A и B.");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"А = {A}, B = {B}");
            int a1 = A;
            int b1 = B;
            A = b1;
            B = a1;
            Console.WriteLine($"А = {A}, B = {B}");

        }
        }
}
