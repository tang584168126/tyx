using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Class
{
    /// <summary>
    /// 计算类
    /// </summary>
    public abstract class Calc
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 计算方法
        /// </summary>
        /// <param name="num1">计算数一</param>
        /// <param name="num2">计算数二</param>
        /// <returns>计算结果</returns>
        public abstract double CalcFunc(double num1, double num2);
        #endregion
    }
}
