/*
 * 题目：猴子吃桃问题：猴子第一天摘下若干个桃子，当即吃了一半，还不瘾，
 * 又多吃了一个第二天早上又将剩下的桃子吃掉一半，又多吃了一个。以后每天早上都吃了
 * 前一天剩下的一半零一个。到第10天早上想再吃时，见只剩下一个桃子了。求第一天共摘了多少。
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question17
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
		    for (int i = 0; i < 9; i++) {
			    sum = (sum + 1) * 2;
		    }
		    Console.WriteLine("第一天共摘"+sum);

            Console.ReadLine();
        }
    }
}
