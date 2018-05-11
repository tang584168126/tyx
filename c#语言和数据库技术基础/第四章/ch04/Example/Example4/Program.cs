using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    /// <summary>
    /// 字符串的连接
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //字符串
            string[] strList = new string[3];

            strList[0] = "2014";
            strList[1] = "07";
            strList[2] = "11";

            //连接字符串
            string str = string.Join("-", strList);

            Console.WriteLine("字符串连接的结果:" + str);

            Console.ReadLine();
        }
    }
}
