using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{

    delegate double DoOperation(double x, double y);

    internal class Sample03
    {

        public static double Minus(double a, double b)
        {
            Console.Write($"{a} - {b}");
            return a - b;
        }

        public static double Plus(double a, double b)
        {
            Console.Write($"{a} + {b}");
            return a + b;
        }

        public static void Process(DoOperation operation, double a, double b)
        {
            Console.WriteLine($" = {operation(a, b)}");  
        }

        static void Main(string[] args)
        {

            DoOperation operation1 = Minus;
            Process(operation1, 22, 15);

            Process(Plus, 22, 15);

            DoOperation multiOperation = delegate (double x, double y)
               {
                   Console.Write($"{x} * {y}");
                   return x * y;
               };

            Process(multiOperation, 22, 15);


            Process(delegate (double x, double y)
            {
                Console.Write($"{x} / {y}");
                return x / y;
            }, 22, 11);

            Console.ReadLine();
        }
    }
}
