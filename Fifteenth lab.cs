using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Fifteenth_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = -1;
            // Первое задание
            Console.WriteLine("Введите размер первого массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            decimal[] arr1 = new decimal[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr1[i] = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите размер втoрого массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            decimal[] arr2 = new decimal[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr2[i] = Convert.ToDecimal(Console.ReadLine());
            First(arr1, arr2);
            Console.WriteLine();



            //Второе задание
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            decimal[] arr3 = new decimal[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr3[i] = Convert.ToDecimal(Console.ReadLine());
            decimal[] secondTaskArr = Second(arr3);
            Console.WriteLine();
            foreach (var item in secondTaskArr) Console.WriteLine(item);
            Console.WriteLine();

            //Третье задание
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            int[] arr4 = new int[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr4[i] = Convert.ToInt32(Console.ReadLine());
            int[] ThirdTaskArr = Third(arr4);
            Console.WriteLine();
            foreach (var item in ThirdTaskArr) Console.WriteLine(item);
            Console.WriteLine();

            // Четвёртое задание
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            decimal[] arr5 = new decimal[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr5[i] = Convert.ToDecimal(Console.ReadLine());
            decimal[] FourthTaskArr = Fourth(arr5);
            Console.WriteLine();
            foreach (var item in FourthTaskArr) Console.WriteLine(item);
            Console.WriteLine();

            // Пятое задание 
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            decimal[] arr6 = new decimal[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr6[i] = Convert.ToDecimal(Console.ReadLine());
            decimal[] FifthTaskArr = Fifth(arr6);
            Console.WriteLine();
            foreach (var item in FifthTaskArr) Console.WriteLine(item);
            Console.WriteLine();

        }

        private static void First(decimal[] arr1, decimal[] arr2)
        {
            decimal[] changer = new decimal[arr2.Length];
            for (int i = 0; i < arr2.Length; i++) changer[i] = arr1[i];
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++)
            {
                arr1[i] = arr2[i];
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = changer[i];
                Console.WriteLine(arr2[i]);
            }

        }
        private static decimal[] Second(decimal[] arr)
        {
            decimal[] outputArr = new decimal[arr.Length];
            decimal arf = 0;
            outputArr[0] = 0;
            outputArr[1] = arr[1];
            for (int i = 2; i < arr.Length; i++) 
            {
                arf = 0;       
                for(int j = 1; j <= i; j++) 
                {
                    arf += arr[j];
                }
                outputArr[i] = arf / i;
            }
            return outputArr;
        }

        private static int[] Third(int[] arr)
        {
            int last = -1;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] % 2 == 1)
                {
                    last = arr[i];
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++) 
            {
                if(arr[i] % 2 == 1) 
                {
                    arr[i] += last;
                }
            }
            return arr;
        }

        private static decimal[] Fourth(decimal[] arr)
        {
            decimal max = arr[0];
            int maxIndex = 0;

            decimal min = arr[0];
            int minIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    maxIndex = i;
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    minIndex = i;
                    min = arr[i];
                }
            }

            for(int i = maxIndex + 1; i < minIndex; i++) 
            {
                arr[i] = 0;
            }

            for (int i = minIndex + 1; i < maxIndex; i++)
            {
                arr[i] = 0;
            }
            return arr;
        }

        private static decimal[] Fifth(decimal[] arr)
        {
            List<decimal> outputArr = new List<decimal>();
            bool changed = false;
            for(int i = 1; i < arr.Length - 1; i++) 
            {
                outputArr.Add(arr[i]);
                if (arr[i] <= arr[0] && arr[i + 1] >= arr[0])
                {
                    outputArr.Add(arr[0]);
                    changed = true;
                }
            }
            outputArr.Add(arr[arr.Length - 1]);

            if (!changed) 
            {
                outputArr.Add(arr[0]);
            }            
            return outputArr.ToArray();
        }
        
    }
}
