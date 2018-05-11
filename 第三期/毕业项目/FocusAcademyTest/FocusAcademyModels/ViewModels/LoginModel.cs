using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FocusAcademy.Models
{
    /// <summary>
    /// 登录模板
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [DisplayName("用户名")]
        [Required(ErrorMessage="{0}不能为空！")]
        public string LoginId { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [DisplayName("密码")]
        [Required(ErrorMessage="{0}不能为空！")]
        [StringLength(18,MinimumLength=6,ErrorMessage="{0}的长度在{2}和{1}之间")]
        public string Password { get; set; }
    }
}
