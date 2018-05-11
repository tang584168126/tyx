using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Friends.Models
{
    public class LoginModel
    {
        [DisplayName("电子邮件")]
        [Required(ErrorMessage = "{0}不得为空")]
        [RegularExpression(@"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$", ErrorMessage = "请输入正确的{0}")]
        public string Mail { get; set; }

        [DisplayName("密码")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string Password { get; set; }
    }
}