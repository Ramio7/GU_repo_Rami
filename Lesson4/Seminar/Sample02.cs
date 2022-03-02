using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{

    public class MyArray
    {
        #region Поля

        private int[] arr;

        #endregion

        #region Свойства

        public int this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }

        #endregion

        #region Конструкторы

        public MyArray(int[] arr)
        {
            this.arr = arr;
        }

        public MyArray(string fileName)
        {
            arr = LoadArrayFromFile(fileName);
        }

        #endregion

        #region Скрытые методы

        private int[] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                return null;

            int[] arr = new int[1000];
            int counter = 0;

            StreamReader sr = new StreamReader(fileName);

          while (!sr.EndOfStream)
            {
                int number = int.Parse(sr.ReadLine());
                arr[counter] = number;
                counter++;
            }

            int[] buf = new int[counter];

            Array.Copy(arr, buf, counter);

            sr.Close();
            return buf;
        }

        #endregion

        #region Публичные методы 

        public int GetElement(int index)
        {
            return arr[index];
        }

        public void SetElement(int index, int value)
        {
            arr[index] = value;
        }

        public void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        #endregion




    }

    public class Sample02
    {

        static void Main(string[] args)
        {

            int[] arr = { 2, 34, -1, 4, -5 };

            MyArray myArray = new MyArray(arr);

            myArray.PrintArray();

            myArray[2] = 10;

            myArray.PrintArray();

            Console.WriteLine();

            MyArray myArray2 = new MyArray(AppDomain.CurrentDomain.BaseDirectory + "MyArray.txt");

            myArray2.PrintArray();

            Console.ReadLine();

        }
    }
}
