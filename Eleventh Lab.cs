using System;

namespace Eleventh_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первое задание
            Console.WriteLine("Введите два числа (Через Enter): ");
            First(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            //Второе задание
            Console.WriteLine("Введите два числа (Через Enter): ");
            Second(Convert.ToInt32(Console.ReadLine()),
                   Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Третье задание
            Console.WriteLine("Введите число: ");
            Third(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Четвёртое задание
            Console.WriteLine("Введите число: ");
            Fourth(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Пятое задание 
            Console.WriteLine("Введите два числа (Через Enter): ");
            Fifth(Convert.ToInt32(Console.ReadLine()),
                  Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Шестое задание 
            Console.WriteLine("Введите номер числа в ряду Фибоначчи: ");
            Sixth(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();
        }

        private static void First(int A, int B)
        {
            for(int i = A; i <= B; i++) 
            {
                for (int j = 0; j < i; j++) Console.Write(i + "\t");
                Console.WriteLine();
            }
        }
        private static void Second(int A, int B)
        {
            int t = 0;
            while (true) 
            {
                if (t + B <= A)
                {
                    t += B;
                }
                else break;
            }
            Console.WriteLine("Длина незанятой части равна: " + (A-t));
        }

        private static void Third(int N)
        {
            int K = 0;
            int sum = 0;
            while (true)
            {
                if (sum < N)
                {
                    sum += ++K;
                }
                else break;
            }
            Console.WriteLine("K: " + K);
            Console.WriteLine("Сумма: " + sum);
        }

        private static void Fourth(double A)
        {
            double P = 1000;
            int count = 0;
            while (true)
            {
                 count++;
                 P += A;
                if (P >= 1100) break;
            }
            Console.WriteLine("Кол-во месяцев: " + count);
            Console.WriteLine("Итоговая сумма: " + P);
        }

        private static void Fifth(int A, int B)
        {
            while(A != 0 && B != 0) 
            {
                if (A > B) A = A % B;
                else B = B % A;            
            }
            Console.WriteLine("НОД: " + (A+B));
        }

        private static int fib(int N)
        {
            if (N == 1 || N == 2) return 1;
            else return fib(N - 1) + fib(N - 2);
        }

        private static void Sixth(int N)
        {
            Console.WriteLine("Число: " + fib(N));
        }
    }
}
