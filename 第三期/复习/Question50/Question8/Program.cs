/*
 * 题目：求s = a + aa + aaa + aaaa + aa...a的值，其中a是一个数字。例如2 + 22 + 222 + 2222 + 22222(此时共有5个数相加)，
 * 几个数相加有键盘控制。
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入a的值：");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入n的值：");
            int n = int.Parse(Console.ReadLine());
            int s = 0, t = 0;
            for (int i = 1; i <= n; i++)
            {
                t += a;
                a = a * 10;
                s += t;
            }
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
