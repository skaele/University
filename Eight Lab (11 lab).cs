using System;

namespace Eight_Lab__11_lab_
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
            Third(Convert.ToDouble(Console.ReadLine()),
                  Convert.ToDouble(Console.ReadLine()),
                  Convert.ToDouble(Console.ReadLine()),
                  Convert.ToDouble(Console.ReadLine()),
                  Convert.ToDouble(Console.ReadLine()),
                  Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine();

            // Четвёртое задание
            Console.WriteLine("Введите координаты точки(Через Enter): ");
            Fourth(Convert.ToDouble(Console.ReadLine()),
                   Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();

            // Пятое задание 
            Console.WriteLine("Введите число: ");
            Fifth(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Шестое задание 
            Console.WriteLine("Введите число: ");
            Sixth(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

        }

        private static void First(int A, int B)
        {
            if (A == B)
            {
                A = 0;
                B = 0;
            }
            else
            {
                var t = Math.Max(A, B);
                A = t;
                B = t;
            }
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
        }

        private static void Second(int A, int B, int C)
        {
            int min = A;
            if (B < min) min = B;
            if (C < min) min = C;

            Console.WriteLine("Сумма максимального и предмаксимального числа: " + (A + B + C - min));

        }

        private static double DistanceBetweenTwoPoints(double X1, double Y1, double X2, double Y2) =>
                    Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
        private static void Third(double Xa, double Ya, double Xb, double Yb, double Xc, double Yc)
        {
            var bDistance = DistanceBetweenTwoPoints(Xa, Ya, Xb, Yb);
            var cDistance = DistanceBetweenTwoPoints(Xa, Ya, Xc, Yc);

            if (bDistance > cDistance) Console.WriteLine("B: " + bDistance);

            else Console.WriteLine("C: " + cDistance);
        }

        private static void Fourth(double X, double Y)
        {
            if (Y > 0)
            {
                if (X > 0) Console.WriteLine("Точка находится в первой четверти");
                else Console.WriteLine("Точка находится в второй четверти");
            }
            else
            {
                if (X > 0) Console.WriteLine("Точка находится в четвёртой четверти");
                else Console.WriteLine("Точка находится в третьей четверти");
            }
        }

        private static void Fifth(int A)
        {
            if (A == 0) Console.WriteLine("Нулевое число");
            else 
            {
                if (A % 2 == 0) 
                {
                    if (A < 0) Console.WriteLine("Отрицательное четное число");
                    else  Console.WriteLine("Положительное четное число");
                }
                else
                {
                    if (A < 0) Console.WriteLine("Отрицательное нечетное число");
                    else Console.WriteLine("Положительное нечетное число");
                }
            }
        }

        private static void Sixth(int A)
        {
            if (A / 10 != 0)
            {
                if (A / 100 != 0)
                {
                    if (A % 2 == 0)
                    {
                        if (A < 0) Console.WriteLine("Отрицательное трёхзначное четное число");
                        else Console.WriteLine("Положительное трёхзначное четное число");
                    }
                    else
                    {
                        if (A < 0) Console.WriteLine("Отрицательное трёхзначное нечетное число");
                        else Console.WriteLine("Положительное трёхзначное нечетное число");
                    }
                }
                else
                {
                    if (A % 2 == 0)
                    {
                        if (A < 0) Console.WriteLine("Отрицательное двухзначное четное число");
                        else Console.WriteLine("Положительное двухзначное четное число");
                    }
                    else
                    {
                        if (A < 0) Console.WriteLine("Отрицательное двухзначное нечетное число");
                        else Console.WriteLine("Положительное двухзначное нечетное число");
                    }
                }
            }

            else if (A == 0) Console.WriteLine("Нулевое число");

            else
            {
                if (A % 2 == 0)
                {
                    if (A < 0) Console.WriteLine("Отрицательная четная цифра");
                    else Console.WriteLine("Положительная четная цифра");
                }
                else
                {
                    if (A < 0) Console.WriteLine("Отрицательная нечетная цифра");
                    else Console.WriteLine("Отрицательная четная цифра");
                }
            }
           
        }


    }
}