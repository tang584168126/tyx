
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BookShop.Models
{

    [Serializable()]
    public class User
    {

        private int id;
        private UserState userState;
        private UserRole userRole;
        private string loginId = String.Empty;
        private string loginPwd = String.Empty;
        private string name = String.Empty;
        private string address = String.Empty;
        private string phone = String.Empty;
        private string mail = String.Empty;

        public User() { }


        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public UserState UserState
        {
            get { return this.userState; }
            set { this.userState = value; }
        }

        public UserRole UserRole
        {
            get { return this.userRole; }
            set { this.userRole = value; }
        }

     
        [DisplayName("账号")]
        [Required(ErrorMessage = "账号不得为空")]
        public string LoginId
        {
            get { return this.loginId; }
            set { this.loginId = value; }
        }

        [DisplayName("密码")]
        [Required(ErrorMessage = "密码不得为空")]
        public string LoginPwd
        {
            get { return this.loginPwd; }
            set { this.loginPwd = value; }
        }

        [DisplayName("重复密码")]
        [Required(ErrorMessage = "重复密码不得为空")]
        [Compare("LoginPwd", ErrorMessage = "两次输入密码必须一致")]
        public string PasswordConfirm { get; set; }

        [DisplayName("姓名")]
        [Required(ErrorMessage = "姓名不得为空")]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        [DisplayName("地址")]
        [Required(ErrorMessage = "地址不得为空")]
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        [DisplayName("电话")]
        [Required(ErrorMessage = "电话不得为空")]
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        [DisplayName("电子邮件")]
        [Required(ErrorMessage = "{0}不得为空")]
        [RegularExpression(@"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$", ErrorMessage = "请输入正确的{0}")]
        public string Mail
        {
            get { return this.mail; }
            set { this.mail = value; }
        }


    }
}
