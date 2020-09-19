using System;

namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первое задание
            Console.WriteLine("Введите значение угла в градусах: ");
            FirstTask(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();

            //Второе задание
            Console.WriteLine("Введите значение угла в радианах: ");
            SecondTask(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();

            //Третье задание
            Console.WriteLine("Введите количество конфет A (в кг.)," +
                " стоимость A конфет, B(масса конфет за которую хотите узнать цену)(через Enter): ");
            ThirdTask(Convert.ToDouble(Console.ReadLine()),
                      Convert.ToDouble(Console.ReadLine()),
                      Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();

            //Четвёртое задание
            Console.WriteLine("Введите скорость первой(км/ч), второй машины, расстояние между ними в момент старта, " +
                "время которое они находились в пути\n(через Enter): ");
            FourthTask(Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();

            //Пятое задание
            Console.WriteLine("A·x + B = 0 решение линейного уравненния");
            Console.WriteLine("Введите коэффицены A и B");
            FifthTask(Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()));

            //Шестое задание
            Console.WriteLine("A1·x + B1·y = C1");
            Console.WriteLine("A2·x + B2·y = C2");
            Console.WriteLine("Решение системы линейных уравненний");
            Console.WriteLine("Введите коэффицены A1 и B1 и C1, A2 и B2 и C2(Через Enter): ");
            SixthTask(Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()),
                       Convert.ToDouble(Console.ReadLine()));

        }


        private static void FirstTask(double A)
        {
            Console.WriteLine($"угол A в градусах равен {A}, в радианах {A / 180} pi");
        }

        private static void SecondTask(double A)
        {
            Console.WriteLine($"угол A в радианах равен {A} pi, в градусах {A*180}");

        }

        private static void ThirdTask(double X, double A, double Y)
        {
            Console.WriteLine("Цена за 1 кг: " + A/X);
            Console.WriteLine($"Цена за {Y} кг: " + (A/X)*Y);
        }

        private static void FourthTask(double V1, double V2, double S, double T)
        {
            Console.WriteLine($"Расстояние между машинами после {T} часов: " + ((V1 + V2) * T + S));
        }

        private static void FifthTask(double A, double B)
        {
            Console.WriteLine($"x = " + (-B) / A);
        }
        private static void SixthTask(double A1, double B1, double C1,double A2, double B2, double C2)
        {
            double Det = A1 * B2 - B1 * A2;
            Console.WriteLine("X: " + ((C1 * B2 - B1 * C2) / Det));
            Console.WriteLine("Y: " + ((A1 * C2 - A2 * C1 ) / Det));
        } 
    }
}
