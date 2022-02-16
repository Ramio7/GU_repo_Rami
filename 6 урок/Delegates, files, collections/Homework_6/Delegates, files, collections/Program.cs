using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;
using static Delegates__files__collections.Question_1;
using static Delegates__files__collections.Question_2;

//При проектировании решений было принято за умолчание, что пользователь не вводит ложных данных при запросе от программы

namespace Delegates__files__collections
{

    internal class Program
    {

        public static void Menu(int lessonNumber)
        {
            bool goNext = true;
            while (goNext == true)
            {
                Console.WriteLine($"Приветствую Вас в домашнем задании к Уроку №{lessonNumber} по Основам языка C#.\nМеня зовут Рахимкулов Рамиль и я предлагаю выбрать один из нижеуказанных методов для тестирования:");
                Console.WriteLine("1. Демонтрация работы делегата на примере функций a*x^2 и a*sin(x)\n" +
                    "2. Модификация программы нахождения минимума функции с применением делегата\n" +
                    "3. Использование коллекций при работе с базой данных учащихся\n" +
                    "4. Выход из программы");
                int taskNumber = int.Parse(Console.ReadLine());
                switch (taskNumber)
                {
                    case 1:
                        Solution_1(); 
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 2:
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 3:
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 4:
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
            Menu(6);
            BasicClass.pPause();
        }
    }
}
