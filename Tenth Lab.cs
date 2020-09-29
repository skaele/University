using System;

namespace TenthLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первое задание
            Console.WriteLine("Введите цену за 1 кг. конфет: ");
            First(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            //Второе задание
            Console.WriteLine("Введите число: ");
            Second(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Третье задание
            Console.WriteLine("Введите число: ");
            Third(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Четвёртое задание
            Console.WriteLine("Введите два числа(через enter): ");
            Fourth(Convert.ToDecimal(Console.ReadLine()),
                   Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Пятое задание 
            Console.WriteLine("Введите два числа(через enter): ");
            Fifth(Convert.ToDecimal(Console.ReadLine()),
                   Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

        }

        private static void First(int A)
        {
            for(decimal i = 0.1m; i <= 1;i += 0.1m) 
            {
                Console.WriteLine($"Цена за {i} = {i * A}");
            }
        }
        private static void Second(int A)
        {
            decimal result = 1;
            for (int i = 0; i <= A; i++)
            {
                result *= 1.0m + i / 10m;
            }
            Console.WriteLine("Результат: " + result) ;
        }

        private static void Third(int N)
        {
            decimal result = 0;
            for (int i = 1; i <= (2*N - 1); i += 2)
            {
                result += i;
                Console.WriteLine($"{i}: " + result);
            }
            Console.WriteLine("Результат: " + result);
        }

        private static void Fourth(decimal A, int N)
        {
            decimal a = 1;
            decimal result = 1;
            for(int i = 1; i <= N; i++) 
            {
                a *= A;
                result += a; 
            }
            Console.WriteLine("Результат: " + result);
        }

        private static void Fifth(decimal A, int N)
        {
            decimal a = 1;
            decimal result = 1;
            for (int i = 1; i <= N; i++)
            {
                a *= -A;
                result += a;
            }
            Console.WriteLine("Результат: " + result);
        }

    }
}
