using System;

namespace _7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. Известно, что X кг конфет стоит A рублей. Определить, сколько стоит 1 кг и Y кг этих же конфет.");
            Console.WriteLine("Введите значение X кг");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение A рублей");
            int A = Convert.ToInt32(Console.ReadLine());
            double kg = A / X;
            Console.WriteLine($"1 киллограмм таких конфет стоит {kg} р.");
            Console.WriteLine("Введите вес, стоимость которого вы желаете узнать");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Стоимость {Y} кг равна {Y*kg} р.");




        }
    }
}
