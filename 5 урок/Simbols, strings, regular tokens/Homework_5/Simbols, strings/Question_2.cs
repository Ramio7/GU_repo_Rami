using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;
using System.Text.RegularExpressions;
using System.IO;

namespace Simbols__strings
{
    public static class Message
    {
        private static readonly string[] separators = { ",", ".", "!", "?", ";", ":", " " };

        public static void PrintWords(string message)
        {
            Console.Write("Введите максимальную длину слов для выбора из текста n: ");
            int maxLength = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сейчас анализируется текстовое выражение:\n{message}\n" +
                $"Следующие слова в тексте имеют длину не более {maxLength} символов: ");
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= maxLength)
                {
                    Console.Write($"{words[i]}\t");
                }
            }
        }

        public static string RemoveWords(string message)
        {
            StringBuilder sb = new StringBuilder(message);
            Console.Write("Введите символ по которому необходимо отсеивать слова: ");
            char symbol = char.Parse(Console.ReadLine());
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (Regex.IsMatch(words[i], $"{symbol}$", RegexOptions.IgnoreCase))
                {
                    sb.Replace(words[i], "");
                }
            }
            return sb.ToString();
        }

        public static string FindLongestElement(string message)
        {
            int max = 0;
            int index = 0;
            string[] arr = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                    if (arr[i].Length > max)
                    {
                        max = arr[i].Length;
                        index = i;
                    }
            }
            Console.WriteLine($"Самое длинное слово в сообщении: {arr[index]} стоит на {index + 1} месте");
            return arr[index];
        }

        public static void ThreeLongestWords(string message)
        {
            StringBuilder sb = new StringBuilder(1000);
            StringBuilder sb2 = new StringBuilder(message);
            for (int i = 0; i < 3; i++)
            {
                string LongestWord = FindLongestElement(message);
                sb.Append($"{LongestWord} ");
                sb2.Replace(LongestWord, "");
                message = sb2.ToString();
            }
            Console.WriteLine($"Самые длинные слова в сообщении: {sb}");
        }
    }
    internal class Question_2
    {
        public static void ClassMessage()
        {
            string msg = "Это приветственное сообщение второй задачи пятого урока для обработки";
            bool goNext = true;
            while (goNext == true)
            {
                Console.Write("Выберите операцию для выполнения:\n" +
                    "1. Вывод слов не длинее n символов\n" +
                    "2. Удаление из сообщения слов, оканчивающихся на выбраннный пользователем символ\n" +
                    "3. Поиск самого длинного слова в сообщении\n" +
                    "4. Вывод трёх самых длинных слов в сообщении\n" +
                    "5. Выход из программы\n" +
                    "Ваш выбор: ");
                int taskNumber = int.Parse(Console.ReadLine());
                switch (taskNumber)
                {
                    case 1:
                        Message.PrintWords(msg);
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine(Message.RemoveWords(msg));
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 3:
                        Message.FindLongestElement(msg);
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 4:
                        Message.ThreeLongestWords(msg);
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 5:
                        goNext = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Вы ввели некорректный номер операции. Введите номер из списка.");
                        break;
                }
            }
        }
    }
}
