/*
 * 
 * 题目：一个数如果恰好等于它的因子之和，这个数就称为"完数"。例如6=1＋2＋3。编程找出1000以内的所有完数。
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
		    for (int i = 1; i <= 1000; i++) 
            {
			    int s = 0;
			    for (int j = 1; j < i; j++)
				    if (i % j == 0)
					    s = s + j;
			    if (s == i)
				    Console.Write(i + " " );
		    }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
