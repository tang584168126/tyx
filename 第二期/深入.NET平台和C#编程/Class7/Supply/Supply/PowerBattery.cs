using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply
{
    /// <summary>
    /// 电池
    /// </summary>
    public class PowerBattery:Power
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        public override void Supply()
        {
            Console.WriteLine("电池正在供电...");
        }
        #endregion
    }
}
