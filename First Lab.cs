using System;

namespace Univ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первое задание
            Console.WriteLine(AreaOfRectangleArea(2.7, 19.4)); 
            Console.WriteLine(PerimeterOfRectangle(100.7, 15));
            Console.ReadKey();

            // Второе Задание 
            Console.WriteLine(LenghtOfCircle(100.32133));
            Console.ReadKey();

            // Третье задание
            Console.WriteLine(ArithmeticMeanOfTwoNumbers(1023100, 12313.232));
            Console.ReadKey();

            //Четвёртое задние
            FourthTask(1232131, 1313.2);
            Console.ReadKey();

            //Пятое задние
            FithTask(1232, 131233.2);
            Console.ReadKey();
        }

        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        private static double AreaOfRectangleArea(double A, double B) => A * B;

        /// <summary>
        ///  Периметр прямоугольника
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        private static double PerimeterOfRectangle(double A, double B) => 2 * (A + B);

        /// <summary>
        /// Длинна окружности по диаметру, где pi = 3.14 
        /// </summary>
        /// <param name="D"></param>
        /// <returns></returns>
        private static double LenghtOfCircle(double D) => D * 3.14;

        /// <summary>
        /// Среднее арифмитическое двух чисел
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        private static double ArithmeticMeanOfTwoNumbers(double A, double B) => (A * B) / 2;


        /// <summary>
        /// Четвёртое задание
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        private static void FithTask(double A, double B)
        {
            double a = Math.Abs(A);
            double b = Math.Abs(B);

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a/b);
        }

        /// <summary>
        /// Пятон задание
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        private static void FourthTask(double A, double B) 
        {

            double a = A * A;
            double b = B * B;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }


    }
}
