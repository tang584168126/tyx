/*
 * 题目：将一个正整数分解质因数。例如：输入90,打印出90=2*3*3*5。
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        public void FenJie(int n)
        {
            for (int i = 2; i <= n; i++ )
            {
                if(n%i == 0)
                {
                    Console.Write(i);
                    if(n!=i)
                    {
                        Console.Write("*");
                    }
                    FenJie(n/i);
                }
            }
            Console.ReadLine();
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入n的指：");
            int n = int.Parse(Console.ReadLine());
            Console.Write("分解质因数：" + n + "=");
            Program pm = new Program();
            pm.FenJie(n);

            Console.ReadLine();
        }
    }
}
