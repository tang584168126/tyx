using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 值类型
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //张浩的身高
            int zhangHeight = 170;

            //李明的身高
            int liHeight = 170;

            Console.WriteLine("去年—张浩的身高是{0}cm,李明的身高是{1}cm", zhangHeight, liHeight);

            liHeight = 180;

            Console.WriteLine("今年—张浩的身高是{0}cm,李明的身高是{1}cm", zhangHeight, liHeight);

            Console.ReadLine();
        }
    }
}
