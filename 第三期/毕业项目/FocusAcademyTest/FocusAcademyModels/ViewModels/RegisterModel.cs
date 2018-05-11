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
    /// 注册模板
    /// </summary>
    public class RegisterModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [DisplayName("用户名")]
        [Required(ErrorMessage = "{0}不能为空！")]
        public string LoginId { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [DisplayName("密码")]
        [Required(ErrorMessage = "{0}不能为空！")]
        [StringLength(18, MinimumLength = 6, ErrorMessage = "{0}的长度在{2}和{1}之间")]
        public string Password { get; set; }

        /// <summary>
        /// 重复密码
        /// </summary>
        [DisplayName("重复密码")]
        [Required(ErrorMessage = "{0}不能为空！")]
        [Compare("Password",ErrorMessage="两次输入的密码不一致！")]
        public string PasswordConfirm { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [DisplayName("昵称")]
        [Required(ErrorMessage = "{0}不能为空！")]
        public string NickName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [DisplayName("邮箱")]
        [Required(ErrorMessage = "{0}不能为空！")]
        [RegularExpression(@"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$",ErrorMessage="请输入正确的{0}")]
        public string Email { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        [DisplayName("验证码")]
        [Required(ErrorMessage = "{0}不能为空！")]
        public string SecurityCode { get; set; }
    }
}
