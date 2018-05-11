using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    /// <summary>
    /// 地铁类
    /// </summary>
    public class TrafficMetro : Traffic
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        public override void Run()
        {
            Console.WriteLine("地铁沿轨道运行!");
        }
        #endregion
    }
}
