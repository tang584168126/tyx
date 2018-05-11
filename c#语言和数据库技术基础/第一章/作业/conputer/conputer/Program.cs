using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conputer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 声明变量
            string strName = string.Empty;  //名称
            double dbNum = 0;     //屏幕尺寸
            double dbWeight = 0;    //重量
            #endregion

            #region 输入输出
            Console.WriteLine("请输入名称：");
            strName = Console.ReadLine();
            Console.WriteLine("请输入屏幕尺寸：");
            dbNum = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入重量：");
            dbWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("使用格式字符串输出：");
            Console.WriteLine("名称：{0}  ，屏幕尺寸：{1}  ，重量：{2}", strName, dbNum, dbWeight);
            Console.WriteLine("使用加号输出");
            Console.WriteLine("名称：  " + strName + "，屏幕尺寸：  " + dbNum + "，重量：" + dbWeight);
            #endregion

            Console.ReadLine();
        }
    }
}
