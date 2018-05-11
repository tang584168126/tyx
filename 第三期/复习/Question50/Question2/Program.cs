/*
 * 题目：判断101-200之间有多少个素数，并输出所有素数。
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 101; i <= 200;i++ )
            {
                bool check = true;
                for (int j = 2; j <i;j++ )
                {
                    if(i % j == 0)
                    {
                        check = false;
                        break;                       
                    }
                }
                if(check)
                {
                    Console.WriteLine(i);
                }              
            }
            Console.ReadLine();
        }
    }
}
