using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    /// <summary>
    /// 字符串的拆分
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //字符串
            string str = "长亭外 古道边 芳草碧连天 晚风拂柳笛声残 夕阳山外山";

            //拆分字符串
            string[] strList = str.Split(' ');

            Console.WriteLine("拆分后的字符串:");
            for (int i = 0; i < strList.Length; i++)
            {
                Console.WriteLine(strList[i]);
            }

            Console.ReadLine();
        }
    }
}
