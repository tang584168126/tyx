/*
 * 题目：输入一行字符，分别统计出其中英文字母、空格、数字和其它字符的个数。
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串：");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            Count count = new Count();
            count.GetCount(ch);

            Console.ReadLine();
        }
    }
}
