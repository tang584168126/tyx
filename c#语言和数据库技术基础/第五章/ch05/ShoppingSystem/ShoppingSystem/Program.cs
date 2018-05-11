using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建类的对象
            Menu objMenu = new Menu();

            //引用类的方法
            objMenu.ShowMenu();

            Console.ReadLine();
        }
    }
}
