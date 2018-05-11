using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            StuMenu objStuMenu = new StuMenu();
            objStuMenu.ShowLoginMenu();


            objStuMenu.ShowManageMenu();

            Console.ReadLine();
        }
    }
}
