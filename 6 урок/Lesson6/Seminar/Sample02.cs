using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{


    public class MyCollection<T>{

        private T[] elements;
        private int length = 0;

        public MyCollection() { 

            elements = new T[1000];
        }

        public void Add(T item){
            // elements[length++] = item;
            elements[length] = item;
            length = length + 1;
        }

        public int Count
        {
            get
            {
                return length;
            }
        }

    }

    internal class Sample02
    {
        static void Main(string[] args)
        {
            MyCollection<User> myCollection = new MyCollection<User>();
            myCollection.Add(new User());  
            myCollection.Add(new User());
            myCollection.Add(new User());

            Console.WriteLine(myCollection.Count);

            Console.ReadLine();
        }
    }
}
