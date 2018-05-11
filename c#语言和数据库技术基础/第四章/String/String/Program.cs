using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "* ** *** **** *****";
            string[] str1;
            str1 = str.Split(' ');
            foreach(string temp in str1)
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
    }
}
