using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 声明变量
            int intNum = 0;    //操作选项
            string isok = string.Empty; //是否继续
            #endregion

            #region 主界面
            do
            {
                Console.WriteLine("***********************学员管理系统V1.0**************************");
                Console.WriteLine("\t\t1.新增学员信息\t\t2.修改学员信息");
                Console.WriteLine("\t\t3.删除学员信息\t\t4.查询学员信息");
                Console.WriteLine("\t\t5.退出");
                Console.Write("请输入你的操作选项：");
                intNum = int.Parse(Console.ReadLine());
                switch(intNum)
                {
                    case 1:
                        Console.WriteLine("学 员 管 理 系 统 >> [新增学员信息]");
                        break;
                    case 2:
                        Console.WriteLine("学 员 管 理 系 统 >> [修改学员信息]");
                        break;
                    case 3:
                        Console.WriteLine("学 员 管 理 系 统 >> [删除学员信息]");
                        break;
                    case 4:
                        Console.WriteLine("学 员 管 理 系 统 >> [查询学员信息]");
                        break;
                    case 5:
                        Console.WriteLine("系统退出！欢饮下次使用！");
                        break;
                    default:
                        Console.WriteLine("输入错误！");
                        break;
                }
                Console.WriteLine("是否继续？(y/n)");
                isok = Console.ReadLine();
                if(isok.equalsIgnoreCase("n"))
                {
                    break;
                }
            }while(isok.equalsIgnoreCase("y"));
            #endregion
            Console.ReadLine();
        }
    }
}
