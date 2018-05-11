using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Friends.Models
{
    public class RegisterModel
    {
        [DisplayName("电子邮件")]
        [Required(ErrorMessage = "{0}不得为空")]
        //[DataType(DataType.EmailAddress, ErrorMessage = "{0}格式错误")]
        [RegularExpression(@"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$", ErrorMessage = "请输入正确的{0}")]
        public string Mail { get; set; }

        [DisplayName("真实姓名")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string RealName { get; set; }

        [DisplayName("密码")]
        [Required(ErrorMessage = "{0}不得为空")]
        [MinLength(6,ErrorMessage="{0}至少为6位")]
        public string Password { get; set; }

        [DisplayName("性别")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string Gender { get; set; }


        [DisplayName("生日")]
        [Required(ErrorMessage = "{0}不得为空")]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd")]
        [DataType(DataType.Date)]
        public System.DateTime Birthday { get; set; }


        [DisplayName("身份")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string Situation { get; set; }

        [DisplayName("验证码")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string SecurityCode { get; set; }

        [DisplayName("年")]
        [Required(ErrorMessage = "{0}不得为空")]
        public int Year { get; set; }
        [DisplayName("月")]
        [Required(ErrorMessage = "{0}不得为空")]
        public int Month { get; set; }
        [DisplayName("日")]
        [Required(ErrorMessage = "{0}不得为空")]
        public int Day { get; set; }

    }


}