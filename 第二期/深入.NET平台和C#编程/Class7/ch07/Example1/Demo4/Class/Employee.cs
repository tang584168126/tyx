using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Class
{
    /// <summary>
    /// 员工类
    /// </summary>
    public class Employee
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 回家
        /// </summary>
        /// <param name="objTraffic">交通工具</param>
        public void GoHome(Traffic objTraffic)
        {
            objTraffic.Run();
        }
        #endregion
    }
}
