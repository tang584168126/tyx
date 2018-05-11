using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    /// <summary>
    /// C#的输出
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //设置变量
            string strLesson1 = "Logic Java";
            string strLesson2 = "HTML";
            string strLesson3 = "C#";
            string strLesson4 = "WinForm";

            //输出方式一(使用+号连接)
            Console.WriteLine("第一学期的科目有:" + strLesson1 + "," + strLesson2 + "," + strLesson3 + "," + strLesson4);

            //换行
            Console.WriteLine();

            //输出方式二(使用占位符连接)
            Console.WriteLine("第一学期的科目有:{0},{1},{2},{3}", strLesson1, strLesson2, strLesson3, strLesson4);

            Console.ReadLine();
        }
    }
}
