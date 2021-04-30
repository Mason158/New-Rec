using System;

namespace _4_дз
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Введите первое число: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write(" Введите второе число: ");
            int second = int.Parse(Console.ReadLine());

            if (first < 0 || second < 0)
                Console.Write("Введите корректное число! ");
            else
                Console.WriteLine($" Сумма диапазона чисел между ними: {Range(first, second)}");
            Console.ReadKey();

        }
        static int Range(int n1, int n2)
        {
            if (n1 == n2)
                return n2;
            else if (n1 < n2)
            {
                return n2 + Range(n1, n2 - 1);
            }
            else
            {
                return n1 + Range(n1 - 1, n2);
            }
    }   }
}
