using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new IndexedNames();
            names[0] = "Hello";
            names[1] = "Hello";
            names[2] = "Hello";
            names[3] = "Hello";
            names[4] = "Hello";
            names[5] = "Hello";

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine(names["Hello"]);
            Console.WriteLine(names["2015"]);
            Console.ReadLine();
        }
    }

    class IndexedNames
    {
        private string[] nameList = new string[6];

        public IndexedNames()
        {
            for (int i = 0; i < nameList.Length; i++)
            {
                nameList[i] = "N/A";
            }
        }

        public string this[int index]
        {
            get
            {
                string temp;
                if (index >= 0 && index <= nameList.Length - 1)
                {
                    temp = nameList[index];
                }
                else
                {
                    temp = "";
                }
                return temp;
            }
            set
            {
                if (index >= 0 && index <= nameList.Length - 1)
                {
                    nameList[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < nameList.Length)
                {
                    if (nameList[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return -1;
            }
        }
    }
}
