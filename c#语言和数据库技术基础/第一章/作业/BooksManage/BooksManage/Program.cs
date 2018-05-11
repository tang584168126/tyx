using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManage
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 声明变量
            string strEmil = string.Empty;  //电子邮箱
            string strName = string.Empty;  //会员名
            string strPwd = string.Empty;   //密码
            string strPwd1 = string.Empty;   //确认密码
            #endregion

            #region 输入信息
            Console.Write("请输入电子邮箱：");
            strEmil = Console.ReadLine();
            Console.WriteLine("请输入会员名：");
            strName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            strPwd = Console.ReadLine();
            do{
                Console.WriteLine("请确认密码：");
                strPwd1 = Console.ReadLine();
                if (strPwd1 != strPwd)
                {
                    Console.WriteLine("输入错误！");
                }
                else
                {
                    break;
                }
            }while(true);
            #endregion

            #region 显示信息
            Console.WriteLine("会员名：{0}\t密码:{1}\t电子邮箱：{2}",strName,strPwd,strEmil);
            #endregion

            Console.ReadLine();
        }
    }
}
