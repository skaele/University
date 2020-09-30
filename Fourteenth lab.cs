using System;

namespace Fourteenth_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = -1;
            // Первое задание
            Console.WriteLine("Введите три числа(Через Enter): ");
            N = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[N];
            for (int i = 0; i < N; i++) arr1[i] = i + 1;
            Console.WriteLine("Среднее арифметическое: " + First(arr1, Convert.ToInt32(Console.ReadLine()),
                Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine();

            //Второе задание
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr2[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Элементы массива задают арифметическую прогрессию: " + Second(arr2));
            Console.WriteLine();

            // Третье задание
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            decimal[] arr3 = new decimal[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr3[i] = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Минимальный элемент с чётным индексом: " + Third(arr3));
            Console.WriteLine();

            // Четвёртое задание
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            decimal[] arr4 = new decimal[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr4[i] = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Номер последнего локального максиума: " + Fourth(arr4));
            Console.WriteLine();

            // Пятое задание 
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            decimal[] arr5 = new decimal[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr5[i] = Convert.ToDecimal(Console.ReadLine());
            Fifth(arr5);
            Console.WriteLine();
        }

        private static decimal First(int[] arr, int K, int L)
        {
            int sum = 0;
            for(int i = K; i <= L; i++) 
            {
                sum += arr[i];
            }
            return (decimal)sum / (L - K);
        }
        private static bool Second(int[] arr)
        {
            int difference = arr[arr.Length - 1] - arr[arr.Length - 2];
            for(int i = arr.Length - 2; i > 0; i--) 
            {
                if (arr[i] - arr[i - 1] != difference) return false;
            }
            return true;
        }

        private static decimal Third(decimal[] arr)
        {
            decimal min = arr[2];
            for(int i = 4; i < arr.Length; i += 2) 
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }

        private static decimal Fourth(decimal[] arr)
        {
            decimal max = 1;
            for(int i = 1; i < arr.Length - 1; i++) 
            {
                if(arr[i] > arr[i-1] && arr[i] > arr[i + 1]) max = i;               
            }
            return max;
        }

        private static void Fifth(decimal[] arr)
        {
            for(int i = 0;i < arr.Length-2; i++)
                for(int j = i; j < arr.Length - 1; j++) 
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        Console.WriteLine($"{arr[i]}: {i} {j}");
                        break;
                    }
                }
        }
    }
    
}
