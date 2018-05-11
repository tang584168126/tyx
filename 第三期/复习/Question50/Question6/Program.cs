/*
 * 题目：输入两个正整数m和n，求其最大公约数和最小公倍数。
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0,b = 0,m = 0,n = 0;
            Console.WriteLine("请输入一个正整数：");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("再输入一个正整数：");
            b = int.Parse(Console.ReadLine());

            CommonDivisor cd = new CommonDivisor();
            m = cd.GetResult(a, b);
            n = a * b / m;
            Console.WriteLine("最大公约数：" + m);
            Console.WriteLine("最小公倍数：" + n);

            Console.ReadLine();
        }
    }
}
