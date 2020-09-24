using System;

namespace Seventh_Lab__is_Ten_
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
            Console.WriteLine("Введите три числа (Через Enter): ");
            Second(Convert.ToInt32(Console.ReadLine()),
                   Convert.ToInt32(Console.ReadLine()),
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
            Console.WriteLine("Введите число: ");
            Fifth(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Шестое задание 
            Console.WriteLine("Введите три числа (Через Enter): ");
            Sixth(Convert.ToInt32(Console.ReadLine()),
                  Convert.ToInt32(Console.ReadLine()),
                  Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Седьмое задание 
            Console.WriteLine("Введите три числа (Через Enter): ");
            Seventh(Convert.ToInt32(Console.ReadLine()),
                  Convert.ToInt32(Console.ReadLine()),
                  Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

        }

        private static void First(int A, int B) 
        {
            if (A > 2 && B <= 3) Console.WriteLine("Выражение: A > 2 && B <= 3, истинно");
            else Console.WriteLine("Выражение: A > 2 && B <= 3, ложно ");
        }
        private static void Second(int A, int B, int C)
        {
            if (A < B && B < C) Console.WriteLine("Выражение: A < B < C, истинно ");
            else Console.WriteLine("Выражение: A < B < C, ложно ");
        }

        private static void Third(int A)
        {
            if (A % 2 == 0 && A / 10 != 0) Console.WriteLine("Данное число является четным двузначным");
            else Console.WriteLine("Данное число не является четным двузначным");
        }

        private static void Fourth(int A)
        {
            if ((A / 10) % 10 - A % 10 == A / 100 - (A / 10) % 10) Console.WriteLine("Цифры данного числа образуют возрастающую или убывающую последовательность");
            else Console.WriteLine("Цифры данного числа не образуют возрастающую или убывающую последовательность");
        }

        private static string Reverse(string SomeString)
        {
            char[] chars = SomeString.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        private static void Fifth(int A)
        {
            var Astring = Convert.ToString(A);
            if (Astring == Reverse(Astring)) Console.WriteLine("Данное число читается одинаково слева направо и справа налево");
            else Console.WriteLine("Данное число не читается одинаково слева направо и справа налево"); 
        }

        private static void Sixth(int A, int B, int C)
        {
            if (A * A == B * B + C * C)
                Console.WriteLine("Треугольник прямоугольный");
            else if (B * B == A * A + C * C)
                Console.WriteLine("Треугольник прямоугольный");
            else if (C * C == A * A + B * B)
                Console.WriteLine("Треугольник прямоугольный");
            else
                Console.WriteLine("Треугольник либо не прямоугольный, либо это не треугольник");
        }

        private static void Seventh(int A, int B, int C)
        {
            if(A + B < C && C + A < B && B + C < A) Console.WriteLine("Треугольник существует");
            else Console.WriteLine("Треугольник не существует");
        }
    }
}
