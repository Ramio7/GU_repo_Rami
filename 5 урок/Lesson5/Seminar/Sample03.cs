using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    internal class Sample03
    {
        static void Main(string[] args)
        {
            string message = "За окном потоп, а я ем торт.";

            StringBuilder sb = new StringBuilder(1000);

            sb.Append(message);
            sb.Append(" Очень холодно.");

            Console.WriteLine(sb);

            sb.Insert(3, "огромным ");

            Console.WriteLine(sb);

            sb.Replace("торт", "бутерброд");

            Console.WriteLine(sb);

            Console.ReadLine();

        }
    }
}
