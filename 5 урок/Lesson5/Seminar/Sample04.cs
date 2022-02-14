using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Seminar
{
    internal class Sample04
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("[A-Za-z]{4,8}");
            Console.WriteLine(regex.IsMatch("Hello!"));
            Regex regex02 = new Regex("^[0-9]{1,2}[A-Za-z]{4,8}");
            Console.WriteLine(regex02.IsMatch("42Hello__________________"));

            Regex regex03 = new Regex("^[0-9]{1,2}[A-Za-z]{4,8}$");
            Console.WriteLine(regex03.IsMatch("42Helloqwe"));

            Console.ReadLine();
        }
    }
}
