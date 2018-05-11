using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Father objFather = new Son();

            objFather.GetMoney();

            objFather.GetMarry();

            Console.ReadLine();
        }
    }
}
