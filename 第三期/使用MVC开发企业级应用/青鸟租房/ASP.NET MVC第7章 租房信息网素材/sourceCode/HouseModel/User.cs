using System;
namespace bdqn.houses.Model
{
	/// <summary>
	/// User:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class User
	{
		public User()
		{}
		#region Model
		private int _loginid;
		private string _loginname;
		private string _username;
		private string _password;
		private string _telephone;
		/// <summary>
		/// 
		/// </summary>
		public int LoginId
		{
			set{ _loginid=value;}
			get{return _loginid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginName
		{
			set{ _loginname=value;}
			get{return _loginname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Telephone
		{
			set{ _telephone=value;}
			get{return _telephone;}
		}
		#endregion Model

	}
}

