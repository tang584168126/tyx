using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop.Models
{
    public class User
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 登陆名
        /// </summary>
        public string LoginId { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string LoginPwd { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// 用户角色
        /// </summary>
        public UserRole UserRole { get; set; }

        /// <summary>
        /// 用户状态
        /// </summary>
        public UserState UserState { get; set; }
    }
}
