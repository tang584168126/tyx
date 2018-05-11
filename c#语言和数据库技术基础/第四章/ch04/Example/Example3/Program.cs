using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    /// <summary>
    /// 字符串的大小写转换
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is Michael";

            Console.WriteLine("原字符串:" + str);
            Console.WriteLine("转换为大写字母:" + str.ToUpper());
            Console.WriteLine("转换为小写字母:" + str.ToLower());

            Console.ReadLine();
        }
    }
}
