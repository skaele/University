using System;

namespace Fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первая Задание
            Console.WriteLine("Введите кол-во байт:");
            First(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Вторая Задание
            Console.WriteLine("Введите длину отрезка A и B (Через Enter): ");
            Second(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Третья Задание
            Console.WriteLine("Введите длину отрезка A и B (Через Enter): ");
            Third(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            //Четвёртое задание
            Console.WriteLine("Введите двухзначное число: ");
            Fourth(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            //Пятое задание 
            Console.WriteLine("Введите трёхзначное число: ");
            Fifth(Convert.ToInt32(Console.ReadLine()));
        }

        private static void First(int Bytes) 
        {
            Console.WriteLine($"{Bytes} байт = " + Bytes/1024 + " килобайт");
        }

        private static void Second(int ALenght, int BLenght)
        {
            Console.WriteLine("B умещается на A: " + ALenght/BLenght + " раз(a)");
        }

        private static void Third(int ALenght, int BLenght)
        {
            Console.WriteLine("Остаток отрезка A: " + ALenght%BLenght);
        }

        private static void Fourth(int A)
        {
            Console.WriteLine("Число после замены цифр: " + A % 10 + A / 10);
        }

        private static void Fifth(int A)
        {
            Console.WriteLine("Полученное число: " + A%100 + A/100);
        }

    }
}
