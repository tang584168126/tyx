using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /// <summary>
    /// 界面类
    /// </summary>
    public class StuMenu
    {
        #region 字段
        //登录类对象
        private StuLoginServer objStuLogin = new StuLoginServer();

        //学员操作类对象
        private StuManageServer objStuManage = new StuManageServer();
        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 展示登录界面
        /// </summary>
        public void ShowLoginMenu()
        {
            #region 设置变量
            //操作选项
            string choose = string.Empty;

            //操作选项是否正确
            bool isRight = true;
            #endregion

            #region 界面
            Console.WriteLine("********欢迎使用青鸟学生管理系统********");
            Console.WriteLine("1.登录");
            Console.WriteLine("2.退出");
            Console.Write("请选择你的操作:");
            #endregion

            do
            {
                #region 执行操作
                //设定默认值
                isRight = true;

                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        bool bolResult = this.objStuLogin.LoginServer();
                        if (bolResult)
                        {
                             this.ShowManageMenu();
                        }
                        else
                       {
                             Console.WriteLine("账户/密码错误，请重新输入！");
                             this.ShowLoginMenu();
                       }
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("程序结束,谢谢使用!");
                        break;
                    default:
                        //更改操作选项是否正确
                        isRight = false;

                        Console.Write("你的输入有错误,请重新输入:");
                        break;
                }
                #endregion

            } while (!isRight);
        }

        /// <summary>
        /// 展示操作界面
        /// </summary>
        public void ShowManageMenu()
        {
            #region 设置变量
            //操作选项
            string choose = string.Empty;

            //操作选项是否正确
            bool isRight = true;

            //是否继续
            string answer = "y";
            #endregion

            while (answer.Equals("y"))
            {
                #region 界面
                Console.WriteLine();
                Console.WriteLine("********欢迎使用青鸟学生管理系统********");
                Console.WriteLine("1.查询学员信息");
                Console.WriteLine("2.新增学员信息");
                Console.WriteLine("3.修改学员信息");
                Console.WriteLine("4.删除学员信息");
                Console.WriteLine("5.返回");
                Console.Write("请选择你的操作:");
                #endregion

                do
                {
                  
                    #region 执行操作
                    //设定默认值
                    isRight = true;

                    choose = Console.ReadLine();

                    switch (choose)
                    {
                        case "1":
                            Console.WriteLine("青鸟学生管理系统 >> 查询学员信息");
                            objStuManage.ShowStu();
                            break;
                        case "2":
                            Console.WriteLine("青鸟学生管理系统 >> 新增学员信息");
                            objStuManage.InsertStu();
                            break;
                        case "3":
                            Console.WriteLine("青鸟学生管理系统 >> 修改学员信息");
                            objStuManage.UpdateStu();
                            break;
                        case "4":
                            Console.WriteLine("青鸟学生管理系统 >> 删除学员信息");
                            objStuManage.DeleteStu();
                            break;
                        case "5":
                            answer = "n";

                            Console.WriteLine();
                            this.ShowLoginMenu();

                            break;
                        default:
                            //更改操作选项是否正确
                            isRight = false;

                            Console.Write("你的输入有错误,请重新输入:");
                            break;
                    }
                    #endregion

                } while (!isRight);   
            }
        }
        #endregion
    }
}
