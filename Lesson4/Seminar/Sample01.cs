using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    internal class Sample01
    {
        static void Main(string[] args)
        {
            int a = 1;

            int[] array01;
            array01 = new int[5];
            int[] array02 = new int[10];

            //array02[0] = -1;
            //array02[1] = 5;

            int[] array03 = new int[] { 5, -1, 1, 1, 20, 9, -7 };
            int[] array04 = { 3, -1, 5, 9, 0 };

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array02[i] = random.Next(-10, 11);
            }

            PrintArray(array02);

            Console.WriteLine();

            PrintArray(array03);

            int findElement = 20;
            int index = FindElement(array03, findElement);
            Console.WriteLine("Элемент {0} {1}", findElement, index >= 0 ? $"найден по индексу {index}" : "не найден в массиве");

            Array.Sort(array03);

            PrintArray(array03);

            index = Array.BinarySearch(array03, findElement);
            Console.WriteLine("Элемент {0} {1}", findElement, index >= 0 ? $"найден по индексу {index}" : "не найден в массиве");


            Console.ReadLine();

        }

        public static int FindElement(int[] arr, int e)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == e)
                    return i;
            }

            return -1;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

    }
}
