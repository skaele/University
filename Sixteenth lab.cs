using System;
using System.Collections.Generic;
using System.Linq;

namespace Fifteenth_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = -1;
            // Первое задание
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr1[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] setted = First(arr1);
            foreach (var item in setted) Console.WriteLine(item);

            //Второе задание
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr2[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] secondTaskArr = Second(arr2);
            foreach (var item in secondTaskArr) Console.WriteLine(item);

            // Третье задание
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            decimal[] arr3 = new decimal[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr3[i] = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
            decimal[] thirdTaskArr = Third(arr3);
            foreach (var item in thirdTaskArr) Console.WriteLine(item);

            // Четвёртое задание
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            decimal[] arr4 = new decimal[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr4[i] = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
            decimal[] FourthTaskArr = Fourth(arr4);
            foreach (var item in FourthTaskArr) Console.WriteLine(item);

            // Пятое задание 
            Console.WriteLine("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            decimal[] arr5 = new decimal[N];
            Console.WriteLine("Введите значения для элементов массива: ");
            for (int i = 0; i < N; i++) arr5[i] = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
            decimal[] FifthTaskArr = Fifth(arr5);
            foreach (var item in FifthTaskArr) Console.WriteLine(item);
          
        }

        private static int[] First(int[] arr) 
        {
            List<int> outputarr = new List<int>();
            outputarr.Add(arr[0]);
            for(int i = 1; i < arr.Length; i++) 
            {
                if(arr[i-1] != arr[i]) 
                {
                    outputarr.Add(arr[i]);
                }
            }
            return outputarr.ToArray();
        }
        
        private static int[] Second(int[] arr)
        {
            List<int> outputArr = new List<int>();
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach(var item in arr) 
            {
                if (counts.ContainsKey(item)) counts[item]++;
                else counts[item] = 1;
            }
            foreach(var key in counts.Keys) 
            {
                if (counts[key] == 2) outputArr.Add(key);
            }
            return outputArr.ToArray();
        }

        private static decimal[] Third(decimal[] arr)
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

            List<decimal> outputArr = new List<decimal>(arr);

            outputArr.Insert(maxIndex + 1, 0);
            outputArr.Insert(minIndex, 0);

            return outputArr.ToArray();
        }

        private static decimal[] Fourth(decimal[] arr)
        {
            List<decimal> outputArr = new List<decimal>();
            foreach(var item in arr) 
            {
                outputArr.Add(item);
                if (item < 0)
                {
                    outputArr.Add(0);
                }
            }
            return outputArr.ToArray();
        }

        private static decimal[] Fifth(decimal[] arr)
        {
            List<decimal> outputArr = new List<decimal>();
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    outputArr.Add(0);
                }
                outputArr.Add(item);                
            }
            return outputArr.ToArray();
        }

    }
}
