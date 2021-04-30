using System;

namespace _6_дз
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] com = new int[4];
            int[] us = new int[4];
            int user = 0, counter = 0;

            CheckDigits(com, 4);

            Console.WriteLine("\nИгра Быки и Коровы \n");

            do
            {
                counter++;
                UserInput(user, us, 4);

                Console.WriteLine($" Быки:  {Bulls(com, us, 4)}");
                Console.WriteLine($" Коровы:  {Cows(com, us, 4)}");
            } while (Bulls(com, us, 4) != 4);

            if (Bulls(com, us, 4) == 4)
            {
                Console.WriteLine("\n\t Отлично!");
                Console.WriteLine($"\n Попытки {counter}");
            }
        }

        static void MoveNumber(int num, int[] arr, int size)
        {
            for (int i = 3; i >= 0; i--)
            {
                arr[i] = num % 10;
                num /= 10;
            }
        }

        static void Random(int[] arr, int size)
        {
            Random rand = new Random();
            int num = rand.Next(1000, 9999);
            MoveNumber(num, arr, size);
        }

        static void UserInput(int num, int[] arr, int size)
        {
            Console.WriteLine(" Введите число : "); num = int.Parse(Console.ReadLine());

            while (num < 1000 || num > 9999)
            {
                Console.WriteLine("\nПожалуйста, введите число в диапазоне от 1000 до 9999!");
                Console.WriteLine("Введите число : "); num = int.Parse(Console.ReadLine());
            }

            MoveNumber(num, arr, size);
        }

        static bool SameDigits(int[] arr, int size)
        {
            int counter = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j]) counter++;
                }
            }
            return (counter != 0);
        }

        static void CheckDigits(int[] arr, int size)
        {
            do
            {
                Random(arr, size);
            } while (SameDigits(arr, size));
        }

        static int Bulls(int[] comNum, int[] usNum, int size)
        {
            int result = 0;

            for (int i = 0; i < size; i++)
            {
                if (comNum[i] == usNum[i]) result++;
            }
            return result;
        }

        static int Cows(int[] comNum, int[] usNum, int size)
        {
            int result = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (comNum[i] == usNum[j]) result++;
                }
            }
            return result;

        }
    }
}
