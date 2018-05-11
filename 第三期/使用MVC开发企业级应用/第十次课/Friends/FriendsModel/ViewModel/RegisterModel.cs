using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Model
{
    public class RegisterModel
    {
        [DisplayName("电子邮件")]
        [Required(ErrorMessage = "{0}不可为空")]
        [RegularExpression(@"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$", ErrorMessage = "{0}格式错误")]
        public string Mail { get; set; }

        [DisplayName("密码")]
        [Required(ErrorMessage = "{0}不可为空")]
        [StringLength(20,MinimumLength=6,ErrorMessage="{0}长度在{2}到{1}之间")]
        public string Password { get; set; }

        [DisplayName("真实姓名")]
        [Required(ErrorMessage = "{0}不可为空")]
        public string RealName { get; set; }

        [DisplayName("性别")]
        [Required(ErrorMessage = "{0}不可为空")]
        public string Gender { get; set; }

        public DateTime Birthday { get; set; }

        [DisplayName("身份")]
        [Required(ErrorMessage = "{0}不可为空")]
        public string Situation { get; set; }

        [DisplayName("验证码")]
        [Required(ErrorMessage = "{0}不可为空")]
        public string SecurityCode { get; set; }

        [DisplayName("年")]
        [Required(ErrorMessage = "{0}不可为空")]
        public int Year { get; set; }

        [DisplayName("月")]
        [Required(ErrorMessage = "{0}不可为空")]
        public int Month { get; set; }

        [DisplayName("日")]
        [Required(ErrorMessage = "{0}不可为空")]
        public int Day { get; set; }
    }
}
