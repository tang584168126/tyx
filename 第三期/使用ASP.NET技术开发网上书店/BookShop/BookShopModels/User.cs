using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class User
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginId { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public UserRole UserRole { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public UserState UserState { get; set; }
    }
}
