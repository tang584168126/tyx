using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Friends.Model
{
    public class LoginModel
    {
        [DisplayName("电子邮件")]
        [Required(ErrorMessage="{0}不可为空")]
        [RegularExpression(@"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$",ErrorMessage="{0}格式错误")]
        public string Mail { get; set; }

        [DisplayName("密码")]
        [Required(ErrorMessage = "{0}不可为空")]
        public string Password { get; set; }
    }
}
