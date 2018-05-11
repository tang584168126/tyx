using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    /// <summary>
    /// 交流电
    /// </summary>
    public class PowerAc : Power
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 供电
        /// </summary>
        public override void GetPower()
        {
            Console.WriteLine("交流电正在供电...");
        }
        #endregion
    }
}
