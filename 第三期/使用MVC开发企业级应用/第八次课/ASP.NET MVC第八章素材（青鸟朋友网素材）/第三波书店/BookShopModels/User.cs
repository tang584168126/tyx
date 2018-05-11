
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

     
        [DisplayName("�˺�")]
        [Required(ErrorMessage = "�˺Ų���Ϊ��")]
        public string LoginId
        {
            get { return this.loginId; }
            set { this.loginId = value; }
        }

        [DisplayName("����")]
        [Required(ErrorMessage = "���벻��Ϊ��")]
        public string LoginPwd
        {
            get { return this.loginPwd; }
            set { this.loginPwd = value; }
        }

        [DisplayName("�ظ�����")]
        [Required(ErrorMessage = "�ظ����벻��Ϊ��")]
        [Compare("LoginPwd", ErrorMessage = "���������������һ��")]
        public string PasswordConfirm { get; set; }

        [DisplayName("����")]
        [Required(ErrorMessage = "��������Ϊ��")]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        [DisplayName("��ַ")]
        [Required(ErrorMessage = "��ַ����Ϊ��")]
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        [DisplayName("�绰")]
        [Required(ErrorMessage = "�绰����Ϊ��")]
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        [DisplayName("�����ʼ�")]
        [Required(ErrorMessage = "{0}����Ϊ��")]
        [RegularExpression(@"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$", ErrorMessage = "��������ȷ��{0}")]
        public string Mail
        {
            get { return this.mail; }
            set { this.mail = value; }
        }


    }
}
