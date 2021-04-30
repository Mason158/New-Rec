using System;

namespace _2_дз
{
    class Program
    {
        public static void Rec(int n, int r)
        {
            if (n > r)

                n = n % r;

            else

                r = r % n;

            if (n != 0 & r != 0)

                Rec(n, r);

            else

                Console.WriteLine("НОД: " + (n + r).ToString());

        }
        static void Main(string[] args)
        {
            int n = 258;
            int r = 657;
            Rec(n, r);
            Console.ReadKey();
        }
    }
}
