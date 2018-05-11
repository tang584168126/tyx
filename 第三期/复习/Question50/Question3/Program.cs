/*
 *  题目：打印出所有的 水仙花数 ，所谓 水仙花数 是指一个三位数，其各位数字立方和等于该数本身。
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            for (int i = 100; i <= 999; i++)
            {
                if (math.Number(i))
                {
                    Console.WriteLine(i);
                }
            }
                Console.ReadLine();
        }
    }
}
