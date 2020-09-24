using System;

namespace Sixth_Lab
{
    class Program
    {
        public enum DaysOfWeek
        {
            Воскресенье,
            Понедельник,
            Вторник, 
            Среда,
            Четверг, 
            Пятница, 
            Суббота
        }
        static void Main(string[] args)
        {
            // Первое задание 
            Console.WriteLine("Введите целое количество секунд: ");
            First(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Второе задание
            Console.WriteLine("Введите День в году: ");
            Second(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Третье задание
            Console.WriteLine("Введите День в году, День недели когда был новый год (Через Enter): ");
            Third(Convert.ToInt32(Console.ReadLine()), EnumElementIndexByName(Console.ReadLine()));
            Console.WriteLine();

            // Четвёртое задание
            Console.WriteLine("Введите стороны длины сторон прямоугольника и сторону квадрата: ");
            Fourth(Convert.ToInt32(Console.ReadLine()),
                   Convert.ToInt32(Console.ReadLine()), 
                   Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Пятое задание
            Console.WriteLine("Введите год: ");
            Fifth(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

        }

        private static int EnumElementIndexByName(string Day) 
        {
            var arr = Enum.GetNames(typeof(DaysOfWeek));
            for(int index = 0; index < arr.Length; index++)
            {
                if(arr[index].ToLower() == Day.ToLower().Replace(" ", ""))
                {
                    return index;
                }
            }
            return -1;
        }

        private static void First(int Seconds) 
        {
            Console.WriteLine("Количество секунд, прошедших с начала последней минуты: " + Seconds % 60);
        }

        private static void Second(int Days)
        {
            Console.WriteLine("День недели:" + (DaysOfWeek)(Days % 7));
        }

        private static void Third(int Days, int StartDay)
        {
            if (StartDay == -1) Console.WriteLine("Введён несуществующий день недели!!!");
            else Console.WriteLine("День недели: " + (DaysOfWeek)((Days + StartDay) % 7));
        }

        private static void Fourth(int A, int B, int C)
        {
            int H = A / C;
            int V = B / C;
            Console.WriteLine("Количество квадратов: " + (H * V) + "\nОставшаяся площадь : " + (A * B - C * C * H * V));
        }

        private static void Fifth(int Year)
        {
            Console.WriteLine("Номер столетия: " + (((Year - 1) / 100) + 1));
        }

    }


}

