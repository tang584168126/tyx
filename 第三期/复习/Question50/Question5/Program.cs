/*
 *  题目：利用条件运算符的嵌套来完成此题：学习成绩=90分的同学用A表示，60-89分之间的用B表示，60分以下的用C表示。
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入成绩：");
            double score = double.Parse(Console.ReadLine());
            Console.WriteLine(score>=90?"A":(score>=60?"B":"C"));

            Console.ReadLine();
        }
    }
}
