using System;

namespace Univ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первое задание
            Console.WriteLine("Введите четыре числа(через Enter): ");

            Console.WriteLine(DistanceBetweenTwoPoints(Convert.ToDouble(Console.ReadLine()),
                                                       Convert.ToDouble(Console.ReadLine()),
                                                       Convert.ToDouble(Console.ReadLine()),
                                                       Convert.ToDouble(Console.ReadLine())));
            Console.WriteLine();

            //Второе Задание
            Console.WriteLine("Введите три числа(через Enter): ");

            SecondTask(Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine();

            //Третье Задание
            Console.WriteLine("Введите три числа(через Enter): ");

            ThirdTask(Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine();

            //Четвёртое Задание
            Console.WriteLine("Введите четыре числа(через Enter): ");

            FourthTask(Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine();

            //Пятое Задание
            Console.WriteLine("Введите шесть числа(через Enter): ");

            FifthTask(Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()), 
                       Convert.ToDouble(Console.ReadLine()), 
                       Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine();


        }


        private static double DistanceBetweenTwoPoints(double X1, double Y1, double X2, double Y2) =>
                    Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
        private static void SecondTask(double A, double B, double C)
        {
            double AC = Math.Abs(A - C);
            double BC = Math.Abs(B - C);

            Console.WriteLine("AC" + AC);
            Console.WriteLine("BC"+ BC);
            Console.WriteLine("Сумма отрезков: " + (AC + BC));
        }

        private static void ThirdTask(double A, double B, double C) 
        {
            double AC = Math.Abs(A - C);
            double BC = Math.Abs(B - C);

            Console.WriteLine("Произведение отрезков: " + AC * BC);
        }

        private static void FourthTask(double X1, double Y1, double X2, double Y2) 
        {
            double A = Math.Abs(X1 - X2);
            double B = Math.Abs(Y1 - Y2);

            Console.WriteLine("Периметр: " + 2 * (A + B));
            Console.WriteLine("Площадь: " + A * B);
        }

        private static void FifthTask(double X1, double Y1, double X2, double Y2, double X3, double Y3)
        {
            double A = DistanceBetweenTwoPoints(X1, Y1, X2, Y2);
            double B = DistanceBetweenTwoPoints(X2, Y2, X3, Y3);
            double C = DistanceBetweenTwoPoints(X3, Y3, X1, Y1);
            double P = A + B + C;

            Console.WriteLine("Периметр треугольника:" + P);
            Console.WriteLine("Площадь треугольника:" + Math.Sqrt(P * (P - A) * (P - B) * (P-C)));
        }

    }
}
