using System;

namespace _1_дз
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, count = 0;

            Console.WriteLine($" Сумма равняется:: {Sum(2, sum, 1, count)}");
            Console.ReadKey();
        }
        static int Sum(int num, int opr, int step, int count)
        {
            step  = step * 2;
            opr = step;
            opr = opr + step;
            count += opr;

            if (num == 10)
            {
                return count;
            }
            else
            {
                return Sum(num + 1, opr, step, count);
            }
        }
    }
}
