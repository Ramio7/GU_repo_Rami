using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class BasicClass
    {
        /// <summary>
        /// Метод, расчитывающий дистанцию между двумя точками
        /// </summary>
        /// <param name="x1">Координата х первой точки</param>
        /// <param name="x2">Координата х второй точки</param>
        /// <param name="y1">Координата у первой точки</param>
        /// <param name="y2">Координата у второй точки</param>
        /// <returns>Возвращает расчитанное значение</returns>
        public static double getDistance(double x1, double x2, double y1, double y2)
        {
            double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //инициализация переменной dist формулой расчёта дистанции между точек
            return dist; //возврат значения в программу
        }

        /// <summary>
        /// Метод запрашивает у пользователя одну из координат
        /// </summary>
        /// <param name="cName">Наименование координаты</param>
        /// <returns>Возвращает координату, введённую пользователем</returns>
        public static double getCoordinates(string cName)
        {
            Console.WriteLine($"Введите координату {cName}"); //вывод запроса пользователю
            double coord = double.Parse(Console.ReadLine()); //инициализация переменной coord вводом значения через консоль
            return coord; //возврат значения в программу
        }

        /// <summary>
        /// Метод запрашивает у пользователя ввод персональных данных и возвращает введённое значение
        /// </summary>
        /// <param name="pInfo">Наименование персональных данных</param>
        /// <returns>Значение персональных данных пользователя</returns>
        public static string getInfo(string pInfo)
        {
            Console.WriteLine("Введите " + pInfo); // вывод строки с запросом персональных данных "склеиванием"
            pInfo = Console.ReadLine(); // присваивание переменной pInfo введённых пользователем данных
            return pInfo; // возврат в основную программу введённых данных
        }

        public static double getInfo(double pInfo)
        {
            Console.WriteLine("Введите " + pInfo); // вывод строки с запросом персональных данных "склеиванием"
            pInfo = double.Parse(Console.ReadLine()); // присваивание переменной pInfo введённых пользователем данных
            return pInfo; // возврат в основную программу введённых данных
        }

        public static void pText()
        {
            string text; int left; int top;
            Console.WriteLine("Введите отступы строки: \n Слева = ");
            left = int.Parse(Console.ReadLine());
            Console.WriteLine("Сверху = ");
            top = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите текст строки: ");
            text = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(left, top);
            Console.WriteLine(text);
        }

        public static void varExch(int fVar, int sVar)
        {
            int a = fVar;
            int b = sVar;
            //int c;
            Console.WriteLine($"Переменная а = {a}");
            Console.WriteLine($"Переменная b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Переменная а после замены = {a}");
            Console.WriteLine($"Переменная b после замены = {b}");
            Console.WriteLine("Для завершения программы нажмите Enter");
            Console.ReadLine();
        }

        public static string getText()
        {
            string Text = Console.ReadLine();
            return Text;
        }

        public static void printVarRequest(int varNum)
        {
            Console.Write($"Введите {varNum} переменную: ");
        }

        public static void printVarRequest()
        {
            Console.Write($"Введите переменную: ");
        }

        public static void pPause()
        {
            Console.Write("Для выхода из программы нажмите Enter");
            Console.ReadLine();
        }

        public static void pPause1()
        {
            Console.Write("Для выхода в меню нажмите Enter");
            Console.ReadLine();
        }

        public static uint sumOfChars(uint Var)
        {
            uint sum = 0;
            for (int counter = 0; counter < (Var.ToString().Length); counter++)
            {
                sum += uint.Parse(Char.GetNumericValue(Var.ToString(), counter).ToString());
            }
            return sum;
        }

        public static int sumOfChars(int Var)
        {
            int sum = 0;
            for (int counter = 0; counter < (Var.ToString().Length); counter++)
            {
                sum += int.Parse(Char.GetNumericValue(Var.ToString(), counter).ToString());
            }
            return sum;
        }

        public static int sumOfChars(string Var)
        {
            int sum = 0;
            for (int counter = 0; counter < (Var.Length); counter++)
            {
                sum += int.Parse(Char.GetNumericValue(Var, counter).ToString());
            }
            return sum;
        }

        public static void menu(int lessonNumber, string taskList)
        {
            bool goNext = true;
            while (goNext == true)
            {
                Console.WriteLine($"Приветствую Вас в домашнем задании к Уроку №{lessonNumber} по Основам языка C#.\nМеня зовут Рахимкулов Рамиль и я предлагаю выбрать один из нижеуказанных методов для тестирования:");
                Console.WriteLine(taskList);
                int taskNumber = int.Parse(Console.ReadLine());
                switch (taskNumber)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        goNext = false;
                        break;
                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи. Введите номер из списка.");
                        break;
                }
            }
        }
    }
}
