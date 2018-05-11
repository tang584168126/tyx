using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    /// <summary>
    /// 值传递与引用传递
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //数字一
            int num1 = 100;

            //数字二
            int num2 = 50;

            //交换类对象
            Change objChange = new Change();

            #region 交换前
            Console.WriteLine("交换前:");
            Console.WriteLine("num1 = " + num1 + ",num2 = " + num2);
            #endregion

            //换行
            Console.WriteLine();


            //交换数字
            objChange.ChangeNum1(num1, num2);
            //objChange.ChangeNum2(ref num1, ref num2);

            //换行
            Console.WriteLine();

            #region 交换后
            Console.WriteLine("交换后:");
            Console.WriteLine("num1 = " + num1 + ",num2 = " + num2);
            #endregion

            Console.ReadLine();
        }
    }
}
