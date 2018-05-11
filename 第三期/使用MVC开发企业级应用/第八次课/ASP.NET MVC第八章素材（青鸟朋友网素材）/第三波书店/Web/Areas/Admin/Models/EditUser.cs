using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Web.Areas.Admin.Models
{
    public class EditUser
    {

        public int Id
        {
            get;
            set;
        }

        public string LoginId
        {
            get;
            set;
        }

     

        [DisplayName("姓名")]
        [Required(ErrorMessage = "姓名不得为空")]
        public string Name
        {
            get;
            set;
        }


        [DisplayName("地址")]
        [Required(ErrorMessage = "地址不得为空")]
        public string Address
        {
            get;
            set;
        }

        [DisplayName("电话")]
        [Required(ErrorMessage = "电话不得为空")]
        public string Phone
        {
            get;
            set;
        }

        [DisplayName("电子邮件")]
        [Required(ErrorMessage = "{0}不得为空")]
        [RegularExpression(@"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$", ErrorMessage = "请输入正确的{0}")]
        public string Mail
        {
            get;
            set;
        }
    }
}