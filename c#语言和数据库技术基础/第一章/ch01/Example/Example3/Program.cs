using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    /// <summary>
    /// C#程序的输入
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 设置变量
            //姓名
            string strName = string.Empty;

            //年龄
            int intAge = 0;

            //身高
            double dbHeight = 0;
            #endregion

            #region 输入
            Console.Write("请输入姓名:");
            strName = Console.ReadLine();

            Console.Write("请输入年龄:");
            intAge = int.Parse(Console.ReadLine());

            Console.Write("请输入身高(cm):");
            dbHeight = double.Parse(Console.ReadLine());
            #endregion

            #region 输出
            Console.WriteLine();
            Console.WriteLine("姓名是{0},年龄是{1}岁,身高是{2}cm!", strName, intAge, dbHeight);
            #endregion

            Console.ReadLine();
        }
    }
}
