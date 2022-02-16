using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MyClasses;

namespace Delegates__files__collections
{
    internal class Question_2
    {
        public delegate double Function(double x);

        public delegate double LinearFunction(double x, double a, double b);

        public delegate double SquareFunction(double x, double a, double b, double c);

        public static double Linear(double x, double a, double b)
        {
            return a * x + b;
        }

        public static double Sin(double x, double a, double b)
        {
            return a * Math.Sin(x) + b;
        }

        public static double Cos(double x, double a, double b)
        {
            return a * Math.Cos(x) + b;
        }

        public static double Tg(double x, double a, double b)
        {
            return a * Math.Tan(x) + b;
        }

        public static double Square(double x, double a, double b, double c)
        {
            return a * x * x + b * x + c;
        }

        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static void SaveFunc(Function F, string fileName, double start, double end, double step)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = start;
            while (x <= end)
            {
                bw.Write(F(x));
                x += step;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static void LinearSaveFunc(LinearFunction F, string fileName, double start, double end, double step)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = start;
            Console.Write("Формат функции а * х + b.\nПожалуйста, введите значение постоянной а: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите значение постоянной b: ");
            double b = double.Parse(Console.ReadLine());
            while (x <= end)
            {
                bw.Write(F(x,a,b));
                x += step;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static void SquareSaveFunc(SquareFunction F, string fileName, double start, double end, double step)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = start;
            Console.Write("Формат функции а * х^2 + b * x + c.\nПожалуйста, введите значение постоянной а: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите значение постоянной b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите значение постоянной c: ");
            double c = double.Parse(Console.ReadLine());
            while (x <= end)
            {
                bw.Write(F(x, a, b, c));
                x += step;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        public static void Solution_2()
        {
            bool goNext = true;
            while (goNext == true)
            {
                Console.Write("Выберите функцию для вычисления минимума:\n" +
                "1.\tИсходная функция из задания\n" +
                "2.\tЛинейная функция\n" +
                "3.\tФункция синуса\n" +
                "4.\tФункция косинуса\n" +
                "5.\tФункция тангенса\n" +
                "6.\tКвадратичная функция\n" +
                "7.\tВыход в главное меню\n" +
                "Ваш выбор:\t");
                int choise = int.Parse(Console.ReadLine());

                if (choise == 7)
                {
                    goNext = false;
                    Console.Clear();
                    break;
                }

                Console.Write("Пожалуйста, введите точку отсчёта для вычисления минимума функции: ");
                double start = double.Parse(Console.ReadLine());
                Console.Write("Пожалуйста, введите до какого значения по оси Х следует вычислять функцию (значение должно быть больше, чем точка отсчёта): ");
                double end = double.Parse(Console.ReadLine());
                Console.Write("Пожалуйста, введите шаг вычисления значений функции: ");
                double step = double.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        SaveFunc(F, "data.bin", start, end, step);
                        Console.Write("Минимум функции: ");
                        Console.WriteLine(Load("data.bin"));
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 2:
                        LinearSaveFunc(Linear, "data.bin", start, end, step);
                        Console.Write("Минимум функции: ");
                        Console.WriteLine(Load("data.bin"));
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 3:
                        LinearSaveFunc(Sin, "data.bin", start, end, step);
                        Console.Write("Минимум функции: ");
                        Console.WriteLine(Load("data.bin"));
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 4:
                        LinearSaveFunc(Cos, "data.bin", start, end, step);
                        Console.Write("Минимум функции: ");
                        Console.WriteLine(Load("data.bin"));
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 5:
                        LinearSaveFunc(Tg, "data.bin", start, end, step);
                        Console.Write("Минимум функции: ");
                        Console.WriteLine(Load("data.bin"));
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 6:
                        SquareSaveFunc(Square, "data.bin", start, end, step);
                        Console.Write("Минимум функции: ");
                        Console.WriteLine(Load("data.bin"));
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 7:
                        goNext = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи. Введите номер из списка.");
                        break;
                }
            }
        }
    }
}
