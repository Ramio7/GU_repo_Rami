using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{

    public class MyClass
    {
        public string Name { get; set; }   
    }

    internal class Sample01
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Name = "Hello";

            MyClass myClass2 = new MyClass();
            myClass2.Name = "Stanislav";


            Type type = myClass.GetType();
            Type type2 = typeof(MyClass);

            PropertyInfo propertyInfo = type2.GetProperty("Name");
            if (propertyInfo.CanRead)
            {
                Console.WriteLine("Name:" + propertyInfo.GetValue(myClass2));
            }
            if (propertyInfo.CanWrite)
            {
                propertyInfo.SetValue(myClass2, "Ivan");
            }

            Console.WriteLine("Name:" + propertyInfo.GetValue(myClass2));

            Console.ReadLine();
        }
    }
}
