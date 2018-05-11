using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    /// <summary>
    /// 字符串的提取方法
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //字符串
            string str = "aaa.bbb.ccc ";

            #region 设置变量
            //第一次出现.号的位置
            int index1 = 0;

            //最后第一次出现.号的位置
            int index2 = 0;

            //第一次出现!号的位置
            int index3 = 0;

            //最后一次出现!号的位置
            int index4 = 0;
            #endregion

            #region IndexOf和LastIndexOf
            index1 = str.IndexOf(".");
            index2 = str.LastIndexOf(".");
            index3 = str.IndexOf("!");
            index4 = str.LastIndexOf("!");

            Console.WriteLine("第一次出现.号的位置:" + index1);
            Console.WriteLine("最后第一次出现.号的位置:" + index2);
            Console.WriteLine("第一次出现!号的位置:" + index3);
            Console.WriteLine("最后一次出现!号的位置:" + index4);
            #endregion

            //换行
            Console.WriteLine();

            #region Substring
            string str1 = str.Substring(0, 3);

            string str2 = str.Substring(4, 3);

            string str3 = str.Substring(4, 7);

            Console.WriteLine("aaa:" + str1);
            Console.WriteLine("bbb:" + str2);
            Console.WriteLine("bbb.ccc:" + str3);
            #endregion

            //换行
            Console.WriteLine();

            #region Trim
            Console.WriteLine(str + "有空格时的长度是:" + str.Length);
            Console.WriteLine(str + "无空格时的长度是:" + str.Trim().Length);
            #endregion

            Console.ReadLine();
        }
    }
}
