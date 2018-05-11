using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Class
{
    /// <summary>
    /// 加法类
    /// </summary>
    public class CalcAdd : Calc
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        public override double CalcFunc(double num1, double num2)
        {
            double result = 0;

            result = num1 + num2;

            return result;
        }
        #endregion
    }
}
