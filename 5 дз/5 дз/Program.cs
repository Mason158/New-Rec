using System;

namespace _5_дз
{
    enum Week
    {
        Monday = 1,
        Thuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Введите порядковый номер дня недели:");
            int b = Convert.ToInt32(Console.ReadLine());
            var a = (Week)b;
            Console.WriteLine(a);

            b = Convert.ToInt32(Console.ReadLine());


            if (b > 7 || b < 0)
            {
                Console.WriteLine("Неверный день недели!");
            }

            Console.ReadKey();

        }
    }
}
