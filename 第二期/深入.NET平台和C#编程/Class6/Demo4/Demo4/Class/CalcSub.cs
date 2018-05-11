using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Class
{
    /// <summary>
    /// 减法类
    /// </summary>
     public class CalcSub:Calc
     {
         #region 字段

         #endregion

         #region 属性

         #endregion

         #region 方法
         public override double CalcFunc(double num1, double num2)
         {
             double result = 0;
             result = num1 - num2;
             return result;
         }
         #endregion
     }
}
