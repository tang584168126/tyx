using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objStu;

            objStu.id = "001";
            objStu.age = 20;

            objStu.showStu();

            Console.ReadLine();
        }
    }
}
