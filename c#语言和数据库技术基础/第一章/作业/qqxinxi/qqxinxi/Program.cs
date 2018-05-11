using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqxinxi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 声明变量
            string strName = string.Empty;  //昵称
            int intNum = 0;     //等级
            #endregion

            #region 输入输出
            Console.WriteLine("请输入昵称：");
            strName = Console.ReadLine();
            Console.WriteLine("请输入QQ等级：");
            intNum = int.Parse(Console.ReadLine());
            Console.WriteLine("使用加号连接输出：");
            Console.WriteLine(strName + "您好！您的等级是：" + intNum);
            Console.WriteLine("使用格式字符串输出");
            Console.WriteLine("{0}您好！您的等级是：{1}", strName, intNum);
            #endregion

            Console.ReadLine();
        }
    }
}
