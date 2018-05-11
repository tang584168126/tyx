/*
 * 题目：一个整数，它加上100后是一个完全平方数，加上168又是一个完全平方数，请问该数是多少？
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question13
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x=1;x<100000;x++)
            {
                if (Math.Sqrt(x + 100) % 1 == 0)
                {
                    if (Math.Sqrt(x + 100 + 168) % 1 == 0)
                    {
                        Console.WriteLine(x + "加上100后是一个完全平方数，加上168又是一个完全平方数");
                    }
                }
		    }

            Console.ReadLine();
        }
    }
}
