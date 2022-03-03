using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    internal class Sample03
    {
        static void Main(string[] args)
        {
            int[,] arr01 = new int[5, 5];
            int[,] arr02 = { { 2, -1, 1 }, { 2, 3, 0 }, { 12, -8, 9 }, { 0, -1, 3 } };

            FillArray(arr01);
            PrintArray(arr01);
            FindMaxElement(arr01);

            Console.ReadLine();


        }

        static void FillArray(int[,] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(-100, 101);
                }

            }
        }

        static void FindMaxElement(int[,] arr)
        {
            int x = 0;
            int y = 0;
            int max = arr[x, y];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        x = i;
                        y = j;
                    }
                }
            }

            Console.WriteLine($"Максимальное значение элемента массива: {max}");
            Console.WriteLine($"находится по индексу [{x}, {y}]");

        }

        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }

                Console.WriteLine();
                
                

            }
            Console.WriteLine();
        }

    }
}
