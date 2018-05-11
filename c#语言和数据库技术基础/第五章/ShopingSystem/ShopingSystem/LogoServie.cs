using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingSystem
{
    class LogoServie
    {
        #region 字段
        private UserInfo[] user = new UserInfo[30];
        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            for (int i = 0; i < user.Length; i++ )
            {
                user[i] = new UserInfo();
            }
            user[0].Name = "10001";
            user[0].Password = "0000";
            user[0].Type = "1";

            user[1].Name = "10002";
            user[1].Password = "0000";
            user[1].Type = "1";

            user[3].Name = "20001";
            user[3].Password = "1111";
            user[3].Type = "2";

            user[4].Name = "20002";
            user[4].Password = "1111";
            user[4].Type = "2";

        }

        /// <summary>
        /// 登陆操作
        /// </summary>
        public string LoginSys()
        {
            #region 设置变量
            string name = string.Empty;     //登陆用户
            string pwd = string.Empty;      //登陆密码
            int i = 0;
            bool isLogo = true;       //true为登陆成功，false为登录失败
            string result = string.Empty;       //结果
            #endregion

            #region 登陆操作
            do{
                Console.Write("请输入用户：");
                name = Console.ReadLine();
                Console.Write("请输入密码：");
                pwd = Console.ReadLine();
                for (i = 0; i < this.user.Length; i++ )
                {
                    if (this.user[i] != null && this.user[i].Name.Equals("name") && this.user[i].Password.Equals("pwd") )
                    {
                        result = user[i].Type;
                        isLogo = true;
                        break;
                    }
                }
                if(!isLogo)
                {
                    Console.WriteLine("不存在此用户,请确认后重新输入!");
                }
            }while(!isLogo);
            #endregion

            return result;
        }
        

        #endregion
    }
}
