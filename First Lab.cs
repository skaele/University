using System;

namespace First_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первое задание
            Console.WriteLine("Введите два числа(через Enter): ");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Плошадь Прямоугольника: " +
                AreaOfRectangleArea(A, B));

            Console.WriteLine("Периметр Прямоугольника: " + 
                PerimeterOfRectangle(A, B));
            Console.WriteLine();

            // Второе Задание 
            Console.WriteLine("Введите число: ");
            Console.WriteLine("Длинна окружности(Круга)" + LenghtOfCircle(Convert.ToDouble(Console.ReadLine())));
            Console.WriteLine();

            // Третье задание
            Console.WriteLine("Введите два числа(через Enter): ");
            Console.WriteLine("Среднее арифметическое двух чисел: " +
                ArithmeticMeanOfTwoNumbers(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
            Console.WriteLine();

            //Четвёртое задние
            Console.WriteLine("Введите два числа(через Enter): ");
            FourthTask(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();

            //Пятое задние
            Console.WriteLine("Введите два числа(через Enter): ");
            FithTask(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();
        }

        private static double AreaOfRectangleArea(double A, double B) => A * B;

        private static double PerimeterOfRectangle(double A, double B) => 2 * (A + B);

        private static double LenghtOfCircle(double D) => D * 3.14;

        private static double ArithmeticMeanOfTwoNumbers(double A, double B) => (A * B) / 2;

        private static void FithTask(double A, double B)
        {
            double a = Math.Abs(A);
            double b = Math.Abs(B);

            Console.WriteLine("Сумма модулей: " + (a + b));
            Console.WriteLine("Разность модулей: " + (a - b));
            Console.WriteLine("Произведение модулей: " + (a * b));
            Console.WriteLine("Частное двух модулей: " + (a / b));
        }

        private static void FourthTask(double A, double B)
        {

            double a = A * A;
            double b = B * B;

            Console.WriteLine("Сумма квадратов: " + (a + b));
            Console.WriteLine("Разность квадратов: " + (a - b));
            Console.WriteLine("Произведение квадратов: " + (a * b));
            Console.WriteLine("Частное двух квадратов: " + (a / b));
        }


    }
}