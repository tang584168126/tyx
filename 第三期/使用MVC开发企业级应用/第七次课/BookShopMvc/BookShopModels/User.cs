using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookShop.Models
{

	[Serializable()]
	public partial class User
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
        [Required(ErrorMessage="{0}����Ϊ�գ�")]
		public string LoginId
		{
			get { return this.loginId; }
			set { this.loginId = value; }
		}		

        [DisplayName("����")]
        [Required(ErrorMessage="{0}����Ϊ�գ�")]
        [StringLength(18,MinimumLength=6,ErrorMessage="{0}�ĳ�����{2}��{1}֮�䣡")]
		public string LoginPwd
		{
			get { return this.loginPwd; }
			set { this.loginPwd = value; }
		}

        [Compare("LoginPwdConfirm",ErrorMessage="������������벻һ�£�")]
        public string LoginPwdConfirm { get; set; }

		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}		
		
		public string Address
		{
			get { return this.address; }
			set { this.address = value; }
		}		

		public string Phone
		{
			get { return this.phone; }
			set { this.phone = value; }
		}		

        [RegularExpression(@"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$",ErrorMessage="{0}��ʽ����")]
		public string Mail
		{
			get { return this.mail; }
			set { this.mail = value; }
		}		
		
	}
}
