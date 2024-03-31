using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA.Common.Utilities
{
    public static class ArrayHelper
    {
        /// <summary>
        /// نمایش آرایه در کنسول
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="inputArray"></param>
        /// <param name="step">در صورت استفاده از این دستور در حلقه، متغیر شمارنده را وارد کنید</param>
        public static void PrintArray<TInput>(TInput[] inputArray, int? step)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == (inputArray.Length - 1))
                {
                    Console.WriteLine($"{inputArray[i]}   {(step is not null ? $"[Step {step}]" : "")}");
                }
                else
                {
                    Console.Write($"{inputArray[i]} , ");
                }
            }
        }

        public static void PrintArray<TInput>(TInput[] inputArray)
        {
            PrintArray<TInput>(inputArray, step: null);
        }
        public static void PrintArray<TInput>(List<TInput>[] inputArray)
        {
            bool isFirstPrint = false;

            foreach (var list in inputArray)
            {
                foreach (var item in list)
                {
                    if (!isFirstPrint)
                    {
                        Console.Write($"{item}");
                        isFirstPrint = true;
                    }
                    else
                    {
                        Console.Write($" , {item}");
                    }
                }

            }
        }

        /// <summary>
        /// ایجاد آرایه با مقادیر تصادفی
        /// </summary>
        /// <param name="min">کمترین مقدار</param>
        /// <param name="max">بیشترین مقدار</param>
        /// <param name="length">طول آرایه</param>
        /// <param name="isRepeat">تولید مقادیر با تکرار یا خیر</param>
        /// <returns>Array</returns>
        public static T[] GenerateRandomArray<T>
            (int min = 1, int max = 10, int length = 10, bool isRepeat = false)
        {
            var randomNumberGenerator = new Random();
            var numbers = new List<T>();
            T randomNumber;

            if (isRepeat)
            {
                for (int i = 0; i < length; i++)
                {
                    randomNumber = (T)Convert.ChangeType
                        (
                            randomNumberGenerator.NextSingle() * (max - min) + min,
                            typeof(T)
                        );

                    numbers.Add(randomNumber);
                }
                return numbers.ToArray<T>();
            }

            for (int i = 0; i < length; i++)
            {
                do
                {
                    randomNumber = (T)Convert.ChangeType
                        (
                            randomNumberGenerator.NextSingle() * (max - min) + min,
                            typeof(T)
                        );
                } while (numbers.Contains(randomNumber));
                numbers.Add(randomNumber);
            }

            return numbers.ToArray<T>();
        }


    }
}
