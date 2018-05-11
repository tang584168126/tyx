using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    /// <summary>
    /// 汽车类
    /// </summary>
    public class TrafficCar:Traffic
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        public override void Run()
        {
            Console.WriteLine("小汽车沿道路行驶!");
        }
        #endregion
    }
}
