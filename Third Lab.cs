using System;

namespace Third_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первое задание
            Console.WriteLine("Введите два числа(через Enter): ");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            B += A;
            A = B - A;
            B -= A;
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine();

            // Второе задание
            Console.WriteLine("Введите три числа(через Enter): ");
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());

            B += A;
            A = B - A;
            B -= A;

            B += C;
            C = B-C;
            B -= C;

            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("C: " + C);

            // Третье Задание
            Console.WriteLine("Введите число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Значение f(x) в точке {x}: " + Third(x));

            // Четвёртое Задание
            Console.WriteLine("Введите число: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Значение g(x) в точке {x}: " + Fourth(x));

            //Пятое задание
            Console.WriteLine("Введите число: ");
            x = Convert.ToDouble(Console.ReadLine());

            double t = x * x;
            t = t * t; // 4
            Console.WriteLine("n^8: " + t * t);

            // Шестое задание
            Console.WriteLine("Введите число: ");
            x = Convert.ToDouble(Console.ReadLine()); 
            t = x * x;   //2
            double v = t * t * x; // 5
            Console.WriteLine("n^15: " + v*v*v);
        }
        private static double Third(double x) => 3 * Math.Pow(x, 6) - 6 * (x * x) - 7;
        private static double Fourth(double x) => 4 * Math.Pow((x-3), 6) - 7 * Math.Pow((x - 3), 3) + 2;
    }
}
