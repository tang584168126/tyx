using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply
{
    /// <summary>
    /// 电源
    /// </summary>
    public class PowerAc:Power
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        public override void Supply()
        {
            Console.WriteLine("交流电电源正在供电...");
        }
        #endregion
    }
}
