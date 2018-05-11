using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Demo5.Class;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person objPerson1 = new PersonChinese();

            objPerson1.Speak();
            objPerson1.Eat();

            Console.ReadLine();
        }
    }
}
