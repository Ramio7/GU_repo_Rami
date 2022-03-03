using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    internal class Sample04
    {


        static bool IsEvenNumber(int number)
        {
            return number % 2 == 0; 
        }

        static void Main(string[] args)
        {
            List<int> evenList = new List<int>();
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 3, 9, -4, 8, 4, 19 });
            /*

            foreach (int number in list)
            {
                if (IsEvenNumber(number))
                    evenList.Add(number);
            }

            foreach (int number in evenList)
                Console.Write($"{number}\t");
            Console.WriteLine();

            // Через использование делегата
            evenList = list.FindAll(IsEvenNumber);

            foreach (int number in evenList)
                Console.Write($"{number}\t");
            Console.WriteLine();

            */
            // Через анонимный метод
            evenList = list.FindAll(delegate (int number)
            {
                return number % 2 == 0;
            });

            foreach (int number in evenList)
                Console.Write($"{number}\t");
            Console.WriteLine();

            // Через использование лямбда-выражения 
            evenList = list.FindAll(number => number % 2 == 0);

            foreach (int number in evenList)
                Console.Write($"{number}\t");
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
