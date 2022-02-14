using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{

    public class Sample02
    {

        static void Main(string[] args)
        {
            string str01 = "Hello, GeekBrains!";
            char[] arr = new char[] { 'H', 'e', 'l', 'l', 'o' };
            string str02 = new String(arr);




            string str03 = @"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;";

            string str04 = "ABC\tABC";
            string str05 = "C:\\abc\\test\\a.txt";

            Console.WriteLine(str04);
            Console.ReadLine();


            string message = "За окном потоп, а я ем торт.";
            StringUtils.PrintWords(message);

            Console.ReadLine();

            Sample sample01 = new Sample(2);
            Sample sample02 = new Sample(5);

            

            int a = 1;
            int b = 1;

            string s1 = "Hello!";
            string s2 = "Hello!";

           // Console.WriteLine(a == b);

            Console.WriteLine(sample01 == sample02);
            Console.WriteLine(sample01.Equals(sample02));
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1 == s2);
            Console.ReadLine();
        }

    }

    public class Sample
    {
        private int i;

        public int I { 
        get { return i; }
        }

        public Sample(int i)
        {
            this.i = i; 
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Sample))
                return false;

            return i == ((Sample)obj).I;
        }


    }

    public class StringUtils
    {

        private static string[] separators = { ",", ".", "!", "?", ";", ":", " " };

        public static void PrintWords(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 3 && words[i][0] == words[i][words[i].Length - 1])
                {
                    Console.WriteLine(words[i]);
                }
            }

        }
    }
}