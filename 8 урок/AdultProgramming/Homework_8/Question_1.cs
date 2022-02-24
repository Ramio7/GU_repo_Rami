using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    internal class Question_1
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            PropertyInfo[] properties;
            properties = dateTime.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
                Console.WriteLine(property.Name);
            Console.ReadLine();
        }
    }
}
