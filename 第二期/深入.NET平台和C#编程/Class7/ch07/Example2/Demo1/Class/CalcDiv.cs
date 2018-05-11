using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1.Class
{
    /// <summary>
    /// 除法类
    /// </summary>
    public class CalcDiv : Calc
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        public override double CalcFunc(double num1, double num2)
        {
            double result = 0;

            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                MessageBox.Show("除数不能为0!");
            }

            return result;
        }
        #endregion
    }
}
