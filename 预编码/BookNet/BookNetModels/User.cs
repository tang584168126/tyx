using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNet.Models
{
    [Serializable]
    public class User
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 用户注册时间
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 用户电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 用户地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string Eamil { get; set; }

        /// <summary>
        /// 用户积分
        /// </summary>
        public int Integral { get; set; }

        /// <summary>
        /// 用户权限
        /// </summary>
        public UserRole UserRole { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string HeadPortrait { get; set; }
    }
}
