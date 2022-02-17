using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;
using System.Text.RegularExpressions;

namespace Simbols__strings
{
    internal class Program
    {
        public static void Menu(int lessonNumber)
        {
            bool goNext = true;
            while (goNext == true)
            {
                Console.WriteLine($"Приветствую Вас в домашнем задании к Уроку №{lessonNumber} по Основам языка C#.\nМеня зовут Рахимкулов Рамиль и я предлагаю выбрать один из нижеуказанных методов для тестирования:");
                Console.Write("Выберите номер задачи для выполнения:\n" +
                    "1. Анализ логина на корректность (длина, наполнение символами)\n" +
                    "2. Статический класс Message для работы с текстом\n" +
                    "3. Выход из программы\n" +
                    "Ваш выбор: ");
                int taskNumber = int.Parse(Console.ReadLine());
                switch (taskNumber)
                {
                    case 1:
                        Question_1.LoginCheck();
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 2:
                        Question_2.ClassMessage();
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 3:
                        goNext = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи. Введите номер из списка.");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Menu(5);
            BasicClass.pPause();
            Console.Clear();
        }
    }
}
