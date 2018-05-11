using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo4.Class;

namespace Demo4
{
    /// <summary>
    /// 计算工厂类
    /// </summary>
    class CakeFactory
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 获取计算类对象
        /// </summary>
        /// <param name="strChoose"></param>
        /// <returns></returns>
        public Calc GetCalc(string strChoose)
        {
            Calc result = null;

            switch (strChoose)
            {
                case "+":
                    result = new CalcAdd();
                    break;

                case "-":
                    result = new CalcSub();
                    break;

                case "*":
                    result = new CalcMul();
                    break;

                case "/":
                    result = new CalcDiv();
                    break;

                default:
                result = null;
                    break;
            }
            return result;
        }
        #endregion
    }
}
