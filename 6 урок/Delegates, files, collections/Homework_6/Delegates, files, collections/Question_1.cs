using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;

namespace Delegates__files__collections
{

    //public delegate double Fun(double x);
    public delegate double Function(double x, double y);

    internal class Question_1
    {
        static void Table(Function F, double x, double y, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, y));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        //public static double MyFunc(double x)
        //{
        //    return x * x * x;
        //}

        //public static void Calculate(Function operation, double a, double b)
        //{
        //    Console.WriteLine($" = {operation(a, b)}");
        //}

        public static void Solution_1()
        {
            //Console.WriteLine("Таблица функции MyFunc:");

            //Table(new Fun(MyFunc), -2, 2);
            //Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");

            //Table(MyFunc, -2, 2);
            //Console.WriteLine("Таблица функции Sin:");
            //Table(Math.Sin, -2, 2);
            //Console.WriteLine("Таблица функции x^2:");

            //Table(delegate (double x) {
            //    return x * x;
            //}, 0, 3);
            bool goNext = true;
            while (goNext == true)
            {
                Console.Write("Выберите функцию для проверки:\n" +
                "1.\ta*x^2\n" +
                "2.\ta*sin(x)\n" +
                "3.\tВыход в главное меню\n" +
                "Ваш выбор:\t");
                int choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.Write("Введите значение множителя а: ");
                        double fVar = double.Parse(Console.ReadLine());

                        Console.Write("Введите значение переменной x: ");
                        double sVar = double.Parse(Console.ReadLine());

                        Console.Write("Укажите до какого значения х вычислить таблицу (введите число больше х): ");
                        double multiplier = double.Parse(Console.ReadLine());

                        Table(delegate (double a, double x)
                        {
                            return a * Math.Pow(x, 2);
                        }, fVar, sVar, multiplier);
                        BasicClass.pPause1();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Введите значение переменной а: ");
                        fVar = double.Parse(Console.ReadLine());

                        Console.Write("Введите значение переменной x в градусах: ");
                        sVar = double.Parse(Console.ReadLine());

                        Console.Write("Укажите до какого значения х вычислить таблицу (введите число больше х): ");
                        multiplier = double.Parse(Console.ReadLine());

                        Table(delegate (double a, double x)
                        {
                            return a * Math.Sin(x / 57.3);
                        }, fVar, sVar, multiplier);
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
        
    }
}
