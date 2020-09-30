using System;

namespace Twenth_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первое задание
            Console.WriteLine("Введите пять чисел(Через enter): ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B;
            Power3A(A, out B);
            Console.WriteLine("B:" + B);
            A = Convert.ToInt32(Console.ReadLine());
            Power3A(A, out B);
            Console.WriteLine("B:" + B);
            A = Convert.ToInt32(Console.ReadLine());
            Power3A(A, out B);
            Console.WriteLine("B:" + B);
            A = Convert.ToInt32(Console.ReadLine());
            Power3A(A, out B);
            Console.WriteLine("B:" + B);
            A = Convert.ToInt32(Console.ReadLine());
            Power3A(A, out B);
            Console.WriteLine("B:" + B);
            Console.WriteLine();

            // Второе задание
            Console.WriteLine("Введите два числа (Через enter): ");
            Console.WriteLine(Sign(Convert.ToDecimal(Console.ReadLine()))+
                            Sign(Convert.ToDecimal(Console.ReadLine())));
            Console.WriteLine();

            // Третье задание
            Console.WriteLine("Введите шесть чисел (Через enter): ");
            Console.WriteLine("Площади первого кольца: " + RingS(Convert.ToDecimal(Console.ReadLine()),
                                                                Convert.ToDecimal(Console.ReadLine())));
            Console.WriteLine("Площади второго кольца: " + RingS(Convert.ToDecimal(Console.ReadLine()),
                                                                Convert.ToDecimal(Console.ReadLine())));
            Console.WriteLine("Площади третьего кольца: " + RingS(Convert.ToDecimal(Console.ReadLine()),
                                                                Convert.ToDecimal(Console.ReadLine())));
            Console.WriteLine();

            // Четвёртое задание
            Console.WriteLine("Введите шесть чисел (Через enter): ");
            Console.WriteLine("Номер четверти первой точки: " + Quarter(Convert.ToInt32(Console.ReadLine()),
                                                                     Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("Номер четверти второй точки: " + Quarter(Convert.ToInt32(Console.ReadLine()),
                                                                     Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("Номер четверти третьей точки: " + Quarter(Convert.ToInt32(Console.ReadLine()),
                                                                     Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine();

            // Пятое задание
            Console.WriteLine("Введите пять чисел (Через enter): ");
            int t = -1;
            for (int i = 0; i < 5; i++) 
            {
                t = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Факториал для числа {t} равен: " + Fact2(t));
            }
        }

        private static void Power3A(int A, out int B) 
        {
            B = A * A * A;
        }

        private static int Sign(decimal X) 
        {
            if (X < 0) return -1;
            else if (X == 0) return 0;
            else return 1;
        }

        private static decimal RingS(decimal R1, decimal R2) =>
            (decimal)Math.PI * (R1 * R1 - R2 * R2);

        private static int Quarter(int X, int Y) 
        {
            if (X > 0) 
            {
                if (Y > 0) return 1;
                else return 4;
            }
            else
            {
                if (Y > 0) return 2;
                else return 3;
            }
        }

        private static decimal Fact2(int N) 
        {
            decimal mul = 1;
            while(N > 0) 
            {
                mul *= N;
                N -= 2;
            }
            return mul;
        }
    }
}
