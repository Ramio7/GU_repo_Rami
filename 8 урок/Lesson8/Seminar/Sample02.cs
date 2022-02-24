using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Seminar
{
    internal class Sample02
    {

        public static Person LoadPersonFromXml(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            Person person = (Person)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();
            return person;
        }

        public static void SavePersonToXml(string fileName, Person person)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fileStream, person);
            fileStream.Close();
        }

        public static void Main()
        {
            Person person = LoadPersonFromXml(AppDomain.CurrentDomain.BaseDirectory + "Person.xml");
            if (person != null)
            {
                Console.WriteLine($"{person.LastName} {person.FirstName} {person.SecondName} {person.Age}");

                Console.ReadLine();
            }

            person.Age = 36;
            person.FirstName = "Stanislav";

            SavePersonToXml(AppDomain.CurrentDomain.BaseDirectory + "Person.new.xml", person);

            Console.WriteLine("\n***\n");

            person = LoadPersonFromXml(AppDomain.CurrentDomain.BaseDirectory + "Person.new.xml");
            if (person != null)
            {
                Console.WriteLine($"{person.LastName} {person.FirstName} {person.SecondName} {person.Age}");

                Console.ReadLine();
            }

            Console.ReadLine();

        }
    }
}
