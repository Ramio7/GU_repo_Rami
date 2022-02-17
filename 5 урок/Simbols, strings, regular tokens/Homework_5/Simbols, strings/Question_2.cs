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
        private static string[] separators = { ",", ".", "!", "?", ";", ":", " " };

        public static void PrintWords(string message)
        {
            Console.WriteLine("Введите максимальную длину слов для выбора из текста");
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

        public static void RemoveWords(string messange)
        {
            char symbol = char.Parse(Console.ReadLine());
            Regex loginCheck = new Regex("[А_Яа_я]");
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= maxLength)
                {
                    Console.Write($"{words[i]}\t");
                }
            }
        }
    }
    internal class Question_2
    {
        public static void ClassMessage()
        {
            string msg = "Это приветственное сообщение второй задачи пятого урока для обработки";
            Message.PrintWords(msg);
            BasicClass.pPause1();
            Console.Clear();
        }
    }
}
