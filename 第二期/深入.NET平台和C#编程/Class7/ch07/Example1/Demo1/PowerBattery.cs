using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    /// <summary>
    /// 电池类
    /// </summary>
    public class PowerBattery : Power
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
            Console.WriteLine("电池正在供电...");
        }
        #endregion
    }
}
