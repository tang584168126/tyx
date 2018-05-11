using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HouseRent.Model
{
    public class User
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int LoginId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [DisplayName("用户名")]
        [Required(ErrorMessage = "{0}不能为空！")]
        [StringLength(20,MinimumLength=8,ErrorMessage="{0}长度必须在{2}和{1}之间")]
        public string LoginName { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [DisplayName("用户姓名")]
        [Required(ErrorMessage="{0}不能为空！")]
        [StringLength(10,ErrorMessage="{0}字符不能超过{1}")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        [DisplayName("密码")]
        [Required(ErrorMessage="{0}不能为空！")]
        public string Password { get; set; }

        /// <summary>
        /// 用户电话
        /// </summary>
        public string Telephone { get; set; }
    }
}
