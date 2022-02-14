using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    internal class Sample01
    {
        static void Main(string[] args)
        {
            char[] chars =
            {

                'j',
                '\u006A',
                (char)106
            };

            Console.WriteLine(String.Join(" ", chars));
            Console.WriteLine();
            Console.ReadLine();

            char[] chars2 = new char[] { '1', 's', '+', 'M' };
            for (int i = 0; i < chars2.Length; i++)
            {
                UnicodeCategory category = char.GetUnicodeCategory(chars2[i]);

                switch (category)
                {
                    case UnicodeCategory.UppercaseLetter:
                        Console.WriteLine($"{chars2[i]} - буква в верхнем регистре");
                        break;
                    case UnicodeCategory.LowercaseLetter:
                        Console.WriteLine($"{chars2[i]} - буква в нижнем регистре");
                        break;
                    case UnicodeCategory.DecimalDigitNumber:
                        Console.WriteLine($"{chars2[i]} - символ является числом");
                        break;
                    case UnicodeCategory.MathSymbol:
                        Console.WriteLine($"{chars2[i]} - математический символ");
                        break;
                    default:
                        Console.WriteLine($"{chars2[i]} - другое ...");
                        break;
                }

                

            }

            Console.ReadLine();

            char m = 'M';

            Console.WriteLine(char.ToLower(m));

            double d = char.GetNumericValue('¾');
            Console.WriteLine();

        }
    }
}
