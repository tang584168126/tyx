using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /// <summary>
    /// 获取字符串的长度
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;

            Console.Write("请输入一句话:");
            str = Console.ReadLine();

            Console.WriteLine("这句话有" + str.Length + "个字符!");

            Console.ReadLine();
        }
    }
}
