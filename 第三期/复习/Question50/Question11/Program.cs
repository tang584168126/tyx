/*
 * 题目：有1、2、3、4个数字，能组成多少个互不相同且无重复数字的三位数？都是多少？
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        if (i != j && j != k && i != k)
                        {
                            count += 1;
                            Console.WriteLine(i * 100 + j * 10 + k);
                        }
                    }
                }
            }
		    Console.WriteLine("共" + count + "个三位数");

            Console.ReadLine();
        }
    }
}
