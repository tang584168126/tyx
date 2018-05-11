using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingSystem
{
    class Menu
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        public void LogMenu()
        {
            #region 设置变量
            string num = string.Empty;      //登陆界面的选择
            bool isok = true;       //true为真，false为假
            #endregion

            #region 显示登陆界面
            Console.WriteLine("********欢迎使用青鸟超市系统********");
            Console.WriteLine("1.登陆");
            Console.WriteLine("2.退出");
            Console.Write("请选择你的操作：");
            num = Console.ReadLine();
            do{
                isok = true;
                switch (num)
                { 
                    case "1":
                        LogoServie logo = new LogoServie();
                        logo.Init();
                        string strType = logo.LoginSys();
                        if (strType.Equals("1"))
                        {

                        }
                        else
                        {
 
                        }
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("系统退出,谢谢使用！");
                        break;
                    default:
                        isok = false;
                        break;
                }
            }while(!isok);
            #endregion
        }

        private void ReserveMenu()
        { 
        }

        private void cashMenu()
        { 
        }
        #endregion
    }
}
