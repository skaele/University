using System;

namespace Thirdth_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первое задание
            Console.WriteLine("Введите число: ");
            First(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            //Второе задание
            Console.WriteLine("Введите три числа (Через Enter): ");
            Second(Convert.ToInt32(Console.ReadLine()),
                   Convert.ToInt32(Console.ReadLine()),
                   Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Третье задание
            Console.WriteLine("Введите три числа (Через Enter): ");
            Third(Convert.ToInt32(Console.ReadLine()),
                   Convert.ToInt32(Console.ReadLine()),
                   Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Четвёртое задание
            Console.WriteLine("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[N];
            for (int i = 0; i < N; i++) arr1[i] = i + 1;
            Fourth(arr1, arr1.Length);
            Console.WriteLine();

            // Пятое задание 
            Console.WriteLine("Введите число: ");
            N = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[N];
            for (int i = 0; i < N; i++) arr2[i] = i+1; 
            Fifth(arr2, arr2.Length);
            Console.WriteLine();

        }

        private static int[] First(int N)
        {
            int[] arr = new int[N];
            for (int i = 1, c = 0 ; i < N * 2; i += 2, c++) 
            {
                arr[c] = i;
                Console.WriteLine($"{c}: " + arr[c]);
            }
            return arr;
        }
        private static int[] Second(int N, int A, int D)
        {
            int[] arr = new int[N];
            for(int i = 0; i < N; i++) 
            {
                arr[i] = (int)Math.Pow(D, i) * A;
                Console.WriteLine($"{i}: " + arr[i]);
            }
            return arr;
        }

        private static int[] Third(int N, int A, int B)
        {
            int[] arr = new int[N];
            arr[0] = A;
            arr[1] = B;
            int sum = A+B;
            for(int i = 2; i < N; i++) 
            {
                arr[i] = sum;
                sum += arr[i];
            }
            for (int i = 0; i < N; i++) Console.WriteLine($"{i}: " + arr[i]);
            return arr;
        }

        private static void Fourth(int[] A, int N)
        {
            for(int i = 0;i < N/2; i++) 
            {
                Console.WriteLine(A[i]);
                Console.WriteLine(A[N-i-1]);
            }
        }

        private static void Fifth(int[] A, int N)
        {
            for(int i = 1; i < N; i+=2) Console.WriteLine($"{i}: " + A[i]);
            
            Console.WriteLine();

            if ((N - 1) % 2 == 0)
            {
                for (int i = N - 1; i >= 0; i -= 2) Console.WriteLine($"{i}: " + A[i]);
                
            }
            else for (int i = N - 2; i >= 0; i -= 2) Console.WriteLine($"{i}: " + A[i]);              
        }

        
    }
}
