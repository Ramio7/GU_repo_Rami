using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{

    class User
    {
        /*private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }*/

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

    }

    class MyList<TElement>
    {

        private TElement element;

        public TElement Element
        {
            get { return element; }
        }

        public MyList(TElement element)
        {
            this.element = element;
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList users = new ArrayList();

            StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UserList.txt");
            while (!reader.EndOfStream)
            {
                string[] words = reader.ReadLine().Split(' ');
                User user = new User();
                user.Name = words[1];
                user.Surname = words[0];
                user.Birthday = DateTime.Parse(words[2]);
                users.Add(user);
            }

            users.Add(1);
            users.Add(false);
            users.Add("ABCD");

            reader.Close();

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i] is User)
                {
                    Console.WriteLine($"{((User)users[i]).Surname} {((User)users[i]).Name} {((User)users[i]).Birthday.ToShortDateString()}");
                }
                
            }

            //foreach (User user in users)
            //{

            //    Console.WriteLine($"{user.Surname} {user.Name} {user.Birthday.ToShortDateString()}");
            //}


            MyList<String> myList = new MyList<String>("Hello!");
            MyList<Int32> myList1 = new MyList<Int32>(12);
            List<User> users02 = new List<User>();

            /*int[] arr01 = new int[3];
            List<int> lst = new List<int>();
            lst.Add(-5);
            lst.Add(5);
            lst.Add(6);*/


            reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UserList.txt");
            while (!reader.EndOfStream)
            {
                string[] words = reader.ReadLine().Split(' ');
                User user = new User();
                user.Name = words[1];
                user.Surname = words[0];
                user.Birthday = DateTime.Parse(words[2]);
                users02.Add(user);
            }

            users.Add(1);
            users.Add(false);
            users.Add("ABCD");

            reader.Close();

            for (int i = 0; i < users02.Count; i++)
            {
                Console.WriteLine($"{users02[i].Surname} {users02[i].Name} {users02[i].Birthday.ToShortDateString()}");

            }


            Console.ReadLine();
        }
    }
}
