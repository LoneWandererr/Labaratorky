using System;

namespace _6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. Даны переменные A, B, C. Изменить их значения, переместив содержимое A в C, C — в B, B — в A, и вывести новые значения переменных A, B, C.");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"А = {A}, B = {B}, C = {C}");
            int a1 = A;
            int b1 = B;
            int c1 = C;
            A = b1;
            B = c1;
            C = a1;
            Console.WriteLine($"А = {A}, B = {B}, C = {C}");

        }
    }
}
