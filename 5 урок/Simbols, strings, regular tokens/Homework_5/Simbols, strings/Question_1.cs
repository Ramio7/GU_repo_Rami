using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;
using System.Text.RegularExpressions;

namespace Simbols__strings
{
    internal class Question_1
    {
        public static void LoginCheck()
        {
            Console.WriteLine("Введите логин\n(Логин должен содержать только буквы латинского алфавита или цифры, нельзя использовать цифру в качестве первого знака логина)");
            Regex loginCheck = new Regex("[^0-9]{1}[A-Za-z]");
            Regex userLogin = new Regex(Console.ReadLine());
            bool isTrue = false;
            if (userLogin.ToString().Length >= 2 && userLogin.ToString().Length <= 10) isTrue = loginCheck.IsMatch(userLogin.ToString());
            else
            {
                Console.WriteLine("Вы задали логин не верно, попробуйте другой логин!");
                return;
            }
            if (isTrue) Console.WriteLine("Логин зарегистрирован успешно!");
            else Console.WriteLine("Вы задали логин не верно, попробуйте другой логин!");
        }
    }
}
