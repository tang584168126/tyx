using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingSystem
{
    class UserInfo
    {
        #region 字段
        //用户名称
        private string name;

        //用户密码
        private string password;

        //用户类别(1.库存管理员 2.收银管理员)
        private string type;

        #endregion

        #region 属性
        //用户名称
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //用户密码
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        //用户类别
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        #endregion

        #region 方法

        #endregion
    }
}
