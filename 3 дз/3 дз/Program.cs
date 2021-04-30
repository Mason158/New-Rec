using System;

namespace _3_дз
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine($"Результат: {Num(num, pow)}");
            Console.ReadKey();
        }
        static int Num(int num, int pow)
        {
            if (pow == 0)
                return 1;
            else if (pow > 0)
                return num * Num(num, pow - 1);
            else
                return 0;
        }
    }
}
