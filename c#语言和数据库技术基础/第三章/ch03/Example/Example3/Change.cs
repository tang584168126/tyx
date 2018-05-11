using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    /// <summary>
    /// 交换类
    /// </summary>
    public class Change
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        public void ChangeNum1(int num1, int num2)
        {
            int temp = num1;

            num1 = num2;

            num2 = temp;

            Console.WriteLine("交换中:");
            Console.WriteLine("num1 = " + num1 + ",num2=" + num2);
        }

        public void ChangeNum2(ref int num1, ref int num2)
        {
            int temp = num1;

            num1 = num2;

            num2 = temp;

            Console.WriteLine("交换中:");
            Console.WriteLine("num1 = " + num1 + ",num2=" + num2);
        }
        #endregion
    }
}
