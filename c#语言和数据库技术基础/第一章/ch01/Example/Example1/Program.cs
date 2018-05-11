using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /// <summary>
    /// C#程序的常量
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //π值
            const double PI = 3.14;

            //半径值
            int r = 5;

            //周长
            double zhouChang = 2 * PI * r;

            //面积
            double mianji = PI * r * r;

            //输出
            Console.WriteLine("周长是:" + zhouChang);
            Console.WriteLine("面积是:" + mianji);


            Console.ReadLine();
        }
    }
}
